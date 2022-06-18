case ILI9225:
	//LCD Init For 2.2inch LCD Panel with ILI9225.	
	LCD_Write_COM_DATA(0x28, 0x00CE); //soft reset
	delay(80); // Delay 20 ms
	LCD_Write_COM_DATA(0x10, 0x0000); // Set SAP,DSTB,STB
	LCD_Write_COM_DATA(0x11, 0x0000); // Set APON,PON,AON,VCI1EN,VC
	LCD_Write_COM_DATA(0x12, 0x0000); // Set BT,DC1,DC2,DC3
	LCD_Write_COM_DATA(0x13, 0x0000); // Set GVDD
	LCD_Write_COM_DATA(0x14, 0x0000); // Set VCOMH/VCOML voltage
	delay(40); // Delay 20 ms
	
	// Please follow this power on sequence
	LCD_Write_COM_DATA(0x11, 0x0018); // Set APON,PON,AON,VCI1EN,VC
	LCD_Write_COM_DATA(0x12, 0x1121); // Set BT,DC1,DC2,DC3
	LCD_Write_COM_DATA(0x13, 0x0063); // Set GVDD
	LCD_Write_COM_DATA(0x14, 0x3961); // Set VCOMH/VCOML voltage
	LCD_Write_COM_DATA(0x10, 0x0800); // Set SAP,DSTB,STB
	delay(10); // Delay 10 ms
	LCD_Write_COM_DATA(0x11, 0x1038); // Set APON,PON,AON,VCI1EN,VC
	delay(30); // Delay 30 ms
	
	
	LCD_Write_COM_DATA(0x02, 0x0100); // set 1 line inversion

	//R01H:SM=0,GS=0,SS=0 (for details,See the datasheet of ILI9225)
	LCD_Write_COM_DATA(0x01, 0x011C); // set the display line number and display direction
	//R03H:BGR=1,ID0=1,ID1=1,AM=1 (for details,See the datasheet of ILI9225)
	LCD_Write_COM_DATA(0x03, 0x1038); // set GRAM write direction .

	LCD_Write_COM_DATA(0x07, 0x0000); // Display off
	LCD_Write_COM_DATA(0x08, 0x0808); // set the back porch and front porch
	LCD_Write_COM_DATA(0x0B, 0x1100); // set the clocks number per line
	LCD_Write_COM_DATA(0x0C, 0x0000); // CPU interface
	LCD_Write_COM_DATA(0x0F, 0x0501); // Set Osc
	LCD_Write_COM_DATA(0x15, 0x0020); // Set VCI recycling
	LCD_Write_COM_DATA(0x20, 0x0000); // RAM Address
	LCD_Write_COM_DATA(0x21, 0x0000); // RAM Address
	
	//------------------------ Set GRAM area --------------------------------//
	LCD_Write_COM_DATA(0x30, 0x0000); 
	LCD_Write_COM_DATA(0x31, 0x00DB); 
	LCD_Write_COM_DATA(0x32, 0x0000); 
	LCD_Write_COM_DATA(0x33, 0x0000); 
	LCD_Write_COM_DATA(0x34, 0x00DB); 
	LCD_Write_COM_DATA(0x35, 0x0000); 
	LCD_Write_COM_DATA(0x36, 0x00AF); 
	LCD_Write_COM_DATA(0x37, 0x0000); 
	LCD_Write_COM_DATA(0x38, 0x00DB); 
	LCD_Write_COM_DATA(0x39, 0x0000); 
	
	
	// ---------- Adjust the Gamma 2.2 Curve -------------------//
	LCD_Write_COM_DATA(0x50, 0x0603); 
	LCD_Write_COM_DATA(0x51, 0x080D); 
	LCD_Write_COM_DATA(0x52, 0x0D0C); 
	LCD_Write_COM_DATA(0x53, 0x0205); 
	LCD_Write_COM_DATA(0x54, 0x040A); 
	LCD_Write_COM_DATA(0x55, 0x0703); 
	LCD_Write_COM_DATA(0x56, 0x0300); 
	LCD_Write_COM_DATA(0x57, 0x0400); 
	LCD_Write_COM_DATA(0x58, 0x0B00); 
	LCD_Write_COM_DATA(0x59, 0x0017); 
	
	
	
	LCD_Write_COM_DATA(0x0F, 0x0701); // Vertical RAM Address Position
	LCD_Write_COM_DATA(0x07, 0x0012); // Vertical RAM Address Position
	delay(50); // Delay 50 ms
	LCD_Write_COM_DATA(0x07, 0x1017); // Vertical RAM Address Position  

	break;
