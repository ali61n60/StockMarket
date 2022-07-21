`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date: 07/20/2022 05:55:39 PM
// Design Name: 
// Module Name: pwn_tb
// Project Name: 
// Target Devices: 
// Tool Versions: 
// Description: 
// 
// Dependencies: 
// 
// Revision:
// Revision 0.01 - File Created
// Additional Comments:
// 
//////////////////////////////////////////////////////////////////////////////////


module pwn_tb(); 
   reg clk;
   reg rst_n;
   reg [9:0] duty_cycle;
   wire pwm;

   pwm pwm_i0(.clk(clk),
           .rst_n(rst_n),
           .duty_cycle(duty_cycle),
           .pwm(pwm)
           );
    
    always begin
       clk = 1'b0;
       #5;
       clk = 1'b1;
       #5;
    end     
    
    initial begin
       duty_cycle = 10'd400;
       rst_n = 1'b0;
       #1000;
       rst_n = 1'b1;
       #50000;
       duty_cycle = 10'd700; 
    end
    
    
           
 
           


endmodule
