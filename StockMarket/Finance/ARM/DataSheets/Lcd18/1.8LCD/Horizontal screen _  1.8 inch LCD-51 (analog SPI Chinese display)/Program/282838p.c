//////////////////////////////////////////////////////////////////////////////////	 
//本程序只供学习使用，未经作者许可，不得用于其它任何用途
//测试硬件：STC51
//1.44寸TFT_ST7735液晶驱动
//我司提供底层技术支持，任何技术问题欢迎随时交流学习
//版本：V1.0
//版权所有，盗版必究。
//Copyright(C) 中景园电子
//All rights reserved
//********************************************************************************
#include<reg51.h>
#include<absacc.h>
#include<intrins.h>
#include<string.h>
#include<font.h>
#define uchar unsigned char
#define uint unsigned int


//测试硬件平台：STC12C5A60S2/STC12LE5A60S2
//主频：12MHZ
//单片机IO推挽输出设置定义
//#define USE_LANDSCAPE//测试程序横竖屏切换，横屏请开启此宏，竖屏请屏蔽
#define MCU_STC12//如果您使用的单片机不是STC12系列(如STC89C52)请屏蔽此宏定义
#ifdef MCU_STC12
sfr P3M1  = 0xB1;	//P3M1.n,P3M0.n 	=00--->Standard,	01--->push-pull
sfr P3M0  = 0xB2;	//					=10--->pure input,	11--->open drain
#endif


//---------------------------液晶屏接线说明-------------------------------------//
//接线前请参考液晶屏说明书第10页引脚定义
sbit bl        =P1^5;//接模块BL引脚，背光可以采用IO控制或者PWM控制，也可以直接接到高电平常亮
sbit scl       =P1^0;//接模块CLK引脚,接裸屏Pin9_SCL
sbit sda       =P1^1;//接模块DIN/MOSI引脚，接裸屏Pin8_SDA
sbit rs        =P1^3;//接模块D/C引脚，接裸屏Pin7_A0
sbit cs        =P1^4;//接模块CE引脚，接裸屏Pin12_CS
sbit reset     =P1^2;//接模块RST引脚，接裸屏Pin6_RES
//---------------------------End of液晶屏接线---------------------------------//

//定义常用颜色
#define RED  		0xf800
#define GREEN		0x07e0
#define BLUE 		0x001f
#define WHITE		0xffff
#define BLACK		0x0000
#define YELLOW  0xFFE0
#define GRAY0   0xEF7D   
#define GRAY1   0x8410      	
#define GRAY2   0x4208 
  

void  Contrast_Adjust();

code  typFNT_GBK16 hz16[];

void Output_Pixel(uint x,uint y);




void delay_ms(uint time)
{
 uint i,j;
  for(i=0;i<time;i++)
   for(j=0;j<250;j++);
}


//向SPI总线传输一个8位数据
void  SPI_WriteData(uchar Data)
{
	unsigned char i=0;
	for(i=8;i>0;i--)
	{
		if(Data&0x80)	
		sda=1; //输出数据
		else sda=0;
		scl=0;
		scl=1;
		Data<<=1;
	}
}
//向液晶屏写一个8位指令
void  Lcd_WriteIndex(uchar Data)
{
		
		cs=0;
		rs=0;
		SPI_WriteData(Data); 		
		cs=1;
}
//向液晶屏写一个8位数据
void  Lcd_WriteData(uchar Data)
{	
		unsigned char i=0;
		cs=0;
		rs=1;
		SPI_WriteData(Data); 	
		cs=1;
}
//向液晶屏写一个16位数据
void  LCD_WriteData_16Bit(unsigned int Data)
{
	unsigned char i=0;
	cs=0;
	rs=1;
	SPI_WriteData(Data>>8); 	//写入高8位数据
	SPI_WriteData(Data); 			//写入低8位数据
	cs=1;

}

void Reset()
{
    reset=0;
    delay_ms(100);
    reset=1;
    delay_ms(100);
}
//////////////////////////////////////////////////////////////////////////////////////////////
//液晶屏初始化 for S6D02A1
void lcd_initial()
{	Reset();//Reset before LCD Init.
		
	//LCD Init For 1.44Inch LCD Panel with ST7735R.
	Lcd_WriteIndex(0x11);//Sleep exit 
	delay_ms (120);
		
	//ST7735R Frame Rate
	Lcd_WriteIndex(0xB1); 
	Lcd_WriteData(0x01); 
	Lcd_WriteData(0x2C); 
	Lcd_WriteData(0x2D); 

	Lcd_WriteIndex(0xB2); 
	Lcd_WriteData(0x01); 
	Lcd_WriteData(0x2C); 
	Lcd_WriteData(0x2D); 

	Lcd_WriteIndex(0xB3); 
	Lcd_WriteData(0x01); 
	Lcd_WriteData(0x2C); 
	Lcd_WriteData(0x2D); 
	Lcd_WriteData(0x01); 
	Lcd_WriteData(0x2C); 
	Lcd_WriteData(0x2D); 
	
	Lcd_WriteIndex(0xB4); //Column inversion 
	Lcd_WriteData(0x07); 
	
	//ST7735R Power Sequence
	Lcd_WriteIndex(0xC0); 
	Lcd_WriteData(0xA2); 
	Lcd_WriteData(0x02); 
	Lcd_WriteData(0x84); 
	Lcd_WriteIndex(0xC1); 
	Lcd_WriteData(0xC5); 

	Lcd_WriteIndex(0xC2); 
	Lcd_WriteData(0x0A); 
	Lcd_WriteData(0x00); 

	Lcd_WriteIndex(0xC3); 
	Lcd_WriteData(0x8A); 
	Lcd_WriteData(0x2A); 
	Lcd_WriteIndex(0xC4); 
	Lcd_WriteData(0x8A); 
	Lcd_WriteData(0xEE); 
	
	Lcd_WriteIndex(0xC5); //VCOM 
	Lcd_WriteData(0x0E); 
	
	Lcd_WriteIndex(0x36); //MX, MY, RGB mode
Lcd_WriteData(0xA0); 	
#ifdef USE_LANDSCAPE
	Lcd_WriteData(0xA8); //竖屏C8 横屏08 A8
#else
	Lcd_WriteData(0xC8); //竖屏C8 横屏08 A8
#endif		
	//ST7735R Gamma Sequence
	Lcd_WriteIndex(0xe0); 
	Lcd_WriteData(0x0f); 
	Lcd_WriteData(0x1a); 
	Lcd_WriteData(0x0f); 
	Lcd_WriteData(0x18); 
	Lcd_WriteData(0x2f); 
	Lcd_WriteData(0x28); 
	Lcd_WriteData(0x20); 
	Lcd_WriteData(0x22); 
	Lcd_WriteData(0x1f); 
	Lcd_WriteData(0x1b); 
	Lcd_WriteData(0x23); 
	Lcd_WriteData(0x37); 
	Lcd_WriteData(0x00); 	
	Lcd_WriteData(0x07); 
	Lcd_WriteData(0x02); 
	Lcd_WriteData(0x10); 

	Lcd_WriteIndex(0xe1); 
	Lcd_WriteData(0x0f); 
	Lcd_WriteData(0x1b); 
	Lcd_WriteData(0x0f); 
	Lcd_WriteData(0x17); 
	Lcd_WriteData(0x33); 
	Lcd_WriteData(0x2c); 
	Lcd_WriteData(0x29); 
	Lcd_WriteData(0x2e); 
	Lcd_WriteData(0x30); 
	Lcd_WriteData(0x30); 
	Lcd_WriteData(0x39); 
	Lcd_WriteData(0x3f); 
	Lcd_WriteData(0x00); 
	Lcd_WriteData(0x07); 
	Lcd_WriteData(0x03); 
	Lcd_WriteData(0x10);  
	
	Lcd_WriteIndex(0x2a);
	Lcd_WriteData(0x00);
	Lcd_WriteData(0x00+2);
	Lcd_WriteData(0x00);
	Lcd_WriteData(0x80+2);

	Lcd_WriteIndex(0x2b);
	Lcd_WriteData(0x00);
	Lcd_WriteData(0x00+3);
	Lcd_WriteData(0x00);
	Lcd_WriteData(0x80+3);
	
	Lcd_WriteIndex(0xF0); //Enable test command  
	Lcd_WriteData(0x01); 
	Lcd_WriteIndex(0xF6); //Disable ram power save mode 
	Lcd_WriteData(0x00); 
	
	Lcd_WriteIndex(0x3A); //65k mode 
	Lcd_WriteData(0x05); 
	
	
	Lcd_WriteIndex(0x29);//Display on

}



/*************************************************
函数名：LCD_Set_Region
功能：设置lcd显示区域，在此区域写点数据自动换行
入口参数：xy起点和终点
返回值：无
*************************************************/
void Lcd_SetRegion(unsigned int x_start,unsigned int y_start,unsigned int x_end,unsigned int y_end)
{	

	Lcd_WriteIndex(0x2a);
	Lcd_WriteData(0x02);
	Lcd_WriteData(x_start);
	Lcd_WriteData(0x02);
	Lcd_WriteData(x_end);

	Lcd_WriteIndex(0x2b);
	Lcd_WriteData(0x02);
	Lcd_WriteData(y_start+2);
	Lcd_WriteData(0x02);
	Lcd_WriteData(y_end+2);	
	Lcd_WriteIndex(0x2c);
}


void PutPixel(uint x_start,uint y_start,uint color)
{
	Lcd_SetRegion(x_start,y_start,x_start+1,y_start+1);
	LCD_WriteData_16Bit(color);
	
}



void dsp_single_colour(int color)
{
 	uchar i,j;
	Lcd_SetRegion(1,0,161,127);
 	for (i=0;i<129;i++)
    	for (j=0;j<160;j++)
        	LCD_WriteData_16Bit(color);
}
//采用设置窗口方法填充字库数据，相比Gui_DrawFont_GBK16更快速
void Fast_DrawFont_GBK16(uint x, uint y, uint fc, uint bc, uchar *s)
{
	unsigned char i,j;
	unsigned short k;
	uint HZnum;
	HZnum=sizeof(hz16)/sizeof(typFNT_GBK16);
	while(*s) 
	{	
		if((*s) >= 128) 
		{		
			for (k=0;k<HZnum;k++) 
			{
			  if ((hz16[k].Index[0]==*(s))&&(hz16[k].Index[1]==*(s+1)))
			  { 	Lcd_SetRegion(x,y,x+16-1,y+16-1);
				    for(i=0;i<16*2;i++)
				    {
						for(j=0;j<8;j++)
				    	{
							if(hz16[k].Msk[i]&(0x80>>j))	LCD_WriteData_16Bit(fc);
							else 
							{
							if (fc!=bc) LCD_WriteData_16Bit(bc);
							}
						}
					}
					
					
				}
			}
		s+=2;x+=16;
		}
			
		
		else
		s+=1; 
		
	}
}
//此方法描绘汉字较慢
void Gui_DrawFont_GBK16(uint x, uint y, uint fc, uint bc, uchar *s)
{
	unsigned char i,j;
	unsigned short k,x0;
	x0=x;

	while(*s) 
	{	
		if((*s) >= 128) 
		{		
			for (k=0;k<hz16_num;k++) 
			{
			  if ((hz16[k].Index[0]==*(s))&&(hz16[k].Index[1]==*(s+1)))
			  { 
				    for(i=0;i<16;i++)
				    {
						for(j=0;j<8;j++) 
							{
						    	if(hz16[k].Msk[i*2]&(0x80>>j))	PutPixel(x+j,y+i,fc);
								else {
									if (fc!=bc) PutPixel(x+j,y+i,bc);
								}
							}
						for(j=0;j<8;j++) 
							{
						    	if(hz16[k].Msk[i*2+1]&(0x80>>j))	PutPixel(x+j+8,y+i,fc);
								else 
								{
									if (fc!=bc) PutPixel(x+j+8,y+i,bc);
								}
							}
				    }
				}
			  }
			s+=2;x+=16;
		}
		else
		s+=1; 
		
	}
}

void Font_Test(void)
{//中文显示测试全动电子欢迎您因为专业所以注
	dsp_single_colour(WHITE);
	Fast_DrawFont_GBK16(16,10,BLUE,YELLOW,	"中文显示测试");
	Fast_DrawFont_GBK16(32,30,RED,WHITE,	"中景园");
	Fast_DrawFont_GBK16(40,50,BLUE,WHITE,	"欢迎您");
	Fast_DrawFont_GBK16(32,70,WHITE,BLUE, 	"因为专注");
	Fast_DrawFont_GBK16(32,90,WHITE,BLUE,	"所以专业");

	delay_ms(1800);	
}
main()
{
#ifdef MCU_STC12
	P3M1 &= ~(1<<2),	P3M0 |=  (1<<2);	//P3.2 set as push-pull output mode
#endif
	lcd_initial();
	bl=1;
  while(1)
  {
	Font_Test();
    delay_ms(3500);	
    }
 }






