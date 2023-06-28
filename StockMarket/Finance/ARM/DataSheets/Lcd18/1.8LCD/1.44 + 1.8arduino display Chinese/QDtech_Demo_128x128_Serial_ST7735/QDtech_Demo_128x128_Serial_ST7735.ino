// UTFT_Demo_160x128_Serial (C)2013 QDtech Co.,LTD
// This program is a demo of how to use most of the functions
// of the library with a supported display modules.
//
// This demo was made for modules with a screen resolution 
// of 160x128 pixels.
//
// This program requires the UTFT library.
//

#include <UTFT.h>


//for QD_TFT180X SPI LCD Modle
//How to Use the Module Hardware in ArduinoUNO:
//1.BL should be Connect to any IO to Control ,or you can Connect it to VCC so that the BackLight will be alway on.
//2.VCC is Connect to 5V DC.
//3.Every IO should be Connect a Resistor  value between 500ohm~2Kohm in series. 
//Param1:Value Can be:QD_TFT180A/QD_TFT180B/QD_TFT180C
//QD_TFT180A is for ST7735,QD_TFT180B_is for HX8353,QD_TFT180C is for S6D02A1
//Param2 instructions:Connect to LCD_Pin SDA/SDI/MOSI(it means LCD_Model Pin_SDA/SDI/MOSI Connect to Arduino_UNO Pin13)
//Param3 instructions:Connect to LCD_Pin SCL/CLK/SCLK(it means LCD_Model Pin_SCL/CLK/SCLK Connect to Arduino_UNO Pin11)
//Param4 instructions:Connect to LCD_Pin CS/CE(it means LCD_Model Pin_CS/CE Connect to Arduino_UNO Pin10)
//Param5 instructions:Connect to LCD_Pin RST/RESET(it means LCD_Model Pin_RST/RESET Connect to Arduino_UNO Pin8)
//Param6 instructions:Connect to LCD_Pin RS/DC(it means LCD_Model Pin_RS/DC Connect to Arduino_UNO Pin9)

//
UTFT myGLCD(QD_TFT180A,11,13,10,8,9);  // Remember to change the model parameter to suit your display module!
extern uint8_t SmallFont[];
extern uint8_t BigFont[];
extern uint8_t SevenSegNumFont[];
char tfont16[]=
{

0x00,0x00,0x00,0x00,0x0F,0xF0,0x08,0x20,0x08,0x20,0x08,0x20,0x08,0x20,0xFF,0xFF,
0x08,0x20,0x08,0x20,0x08,0x20,0x08,0x20,0x0F,0xF0,0x00,0x00,0x00,0x00,0x00,0x00,/*"中",0*/

0x02,0x00,0x02,0x02,0x02,0x04,0xFA,0xF0,0xAA,0x90,0xAA,0x92,0xAA,0x91,0xAE,0x9E,
0xAA,0x90,0xAA,0x90,0xAA,0x90,0xFA,0xF0,0x02,0x04,0x02,0x02,0x02,0x00,0x00,0x00,/*"景",1*/

0x00,0x00,0x7F,0xFF,0x40,0x02,0x42,0x0A,0x52,0x32,0x53,0xC2,0x52,0x02,0x52,0x02,
0x53,0xF2,0x52,0x0A,0x52,0x0A,0x42,0x3A,0x40,0x02,0x7F,0xFF,0x00,0x00,0x00,0x00,/*"园",2*/

0x00,0x00,0x00,0x00,0x1F,0xF8,0x11,0x10,0x11,0x10,0x11,0x10,0x11,0x10,0xFF,0xFE,
0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x1F,0xF9,0x00,0x01,0x00,0x0F,0x00,0x00,/*"电",3*/


};
void Show_CH_Font16(int x,int y,int FontPos)
{
        char temp,t,t1,k;
	int y0=y;	
	int HZnum;

        for(t=0;t<32;t++)//每个16*16的汉字点阵 有32个字节
	{   
	  temp=tfont16[t+32*FontPos];                    
	  for(t1=0;t1<8;t1++)
	  {
	      if(temp&0x80)
              { 
                myGLCD.setColor(255, 0, 0);//FontColor
                myGLCD.drawPixel(x,y);
              }
	      else 
              { 
                myGLCD.setColor(0, 0, 0);//BackColor
                myGLCD.drawPixel(x,y);
              }

	      temp<<=1;
	      y++;
	      if((y-y0)==16)
	      {
		y=y0;
		x++;
		break;
	      }
	     
	  }  	 
	}   


}
void setup()
{
  randomSeed(analogRead(0));
// Setup the LCD
  myGLCD.InitLCD();
  myGLCD.InitLCD();//Initializes twice to improve reliability
  myGLCD.setFont(SmallFont);
}
void loop()
{
  int i=0;
// Clear the screen and draw the frame
  
  myGLCD.clrScr(); 
  myGLCD.setFont(SmallFont);
  myGLCD.setColor(255, 255, 255);
  myGLCD.setBackColor(255, 0, 0);
  myGLCD.print("Color Test", CENTER, 20);   
  delay (500);
  myGLCD.fillScr(255,0,0);//RED
  delay (500);
  myGLCD.fillScr(0,255,0);//GREEN
  delay (500);
  myGLCD.fillScr(0,0,255);//BLUE
  delay (500);
  
  //En_8X12 Test
  myGLCD.setColor(255, 255, 255);
  myGLCD.setBackColor(255, 0, 0);
   myGLCD.clrScr(); 
  myGLCD.setFont(SmallFont);
  myGLCD.print("En_8X12 Test", CENTER, 20);   
  delay (500);
  
  //myGLCD.setFont(BigFont);
  myGLCD.setFont(SmallFont);
  myGLCD.clrScr(); 
  myGLCD.print("Size:1.44", LEFT, 20);   
  myGLCD.print("Dots:128X128", LEFT, 35);
  myGLCD.print("Driver:ST7735", LEFT, 50);
  myGLCD.print("VA:6 o'clock", LEFT, 65);
  myGLCD.print("www.zjyuan.net", LEFT, 80);  
  delay (3000);
  
 
  
  //SegNum Test
  myGLCD.setColor(255, 255, 255);
  myGLCD.setBackColor(255, 0, 0);
   myGLCD.clrScr(); 
  myGLCD.setFont(SmallFont);
  myGLCD.print("SegNum Test", CENTER, 20);   
  delay (500);
  myGLCD.setFont(SevenSegNumFont);
  for(i=123;i<133;i++)
  {    
  myGLCD.printNumI(i, 0, 50, 4, '0');//delay (5);
  }
  
   //ChineseFont Test
  myGLCD.clrScr(); 
  myGLCD.setFont(SmallFont);
  myGLCD.print("Cn_16X16 Test", CENTER, 20);   
  delay (500);
  Show_CH_Font16(0,50,0);
  Show_CH_Font16(16,50,1);
  Show_CH_Font16(32,50,2);
  Show_CH_Font16(48,50,3);
  delay (2000);
  
}
