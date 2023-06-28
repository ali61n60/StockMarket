`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date: 07/20/2022 05:49:42 PM
// Design Name: 
// Module Name: pwm
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


module pwm(
    input clk,
    input rst_n,
    input [9:0] duty_cycle,
    output pwm
    );
    reg[9:0] counter;
    reg pwm_reg;
    
    
    assign pwm= pwm_reg;
    
    always @(posedge clk)
    begin
        if(rst_n==1'b0)
           counter<=10'd0;
        else
           counter <= counter + 1'b1;
    end
    
    always @(posedge clk)
    begin
       if(counter<duty_cycle)
          pwm_reg <= 1'b1;
       else
          pwm_reg <= 1'b0;
    end
    
    
    
endmodule
