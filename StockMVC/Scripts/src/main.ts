import * as Drawer from "./DrawLib/Drawer";
import Drawer1 = Drawer.Drawer;
import Point = Drawer.Point;
import { sayHello } from "./greet";

function showHello(divName: string, name: string) {
    const elt = document.getElementById(divName);
    elt.innerText = sayHello(name);
}




function DrawLine(canvasId:string,x1:number,y1:number,x2:number,y2:number,color:string) {
    let drawer = new Drawer1(canvasId);
    let p1 = new Point();
    p1.x = x1;
    p1.y = y1;
    let p2 = new Point();
    p2.x =x2;
    p2.y = y2;
    drawer.DrawLine(p1, p2,color);
}

global.ShowHello = showHello;
global.DrawLine = DrawLine;



