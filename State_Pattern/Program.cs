//Behavioral Pattern
// assignment of responsibilites between object


/*Like Strategy pattern 
 * The main Diffrence is :
 * State : States know about each other
 * Strategy : Childs don't know any thing about each other
  
y3ny el composition mwgod fl state fy el Istate we el Main class


// state is extension of strategy
 * */


using State_Pattern;

var player = new Player(new InitialState());
player.HandleMove1();
