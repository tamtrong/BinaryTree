var node2 = {value:9 , point:{x:150, y:150}};
var node3 = {value:5 , point:{x:300, y:100}};
var node4 = {value:10 , point:{x:400, y:200}};
var node5 = {value:12 , point:{x:300, y:400}};
var node1 = {value:8 , point:{x:100, y:200}, childrens:[node2, node3]};


var nodePath = [node1, node2, node3, node4, node5];

   console.log(node1);
function drawNode(myContext, node, radius)
{
    myContext.beginPath();
    myContext.arc(node.point.x, node.point.y, radius,0, 2*Math.PI);    
    context.font = "20px serif"
    context.fillStyle = "#000000";
    context.fillText (node.value, node.point.x, node.point.y);
     myContext.stroke();
     myContext.closePath();

};

