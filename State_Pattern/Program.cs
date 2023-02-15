//Behavioral Pattern
// assignment of responsibilites between object


/*Like Strategy pattern 
 * The main Diffrence is :
 * State : States know about each other
 * Strategy : Childs don't know any thing about each other
  
y3ny el composition mwgod fl state fy el Istate we el Main class




// state is extension of strategy
 * */

// All Sub states is treated as one state so all treated from player as it contain one state 
// So when working with state please make all data properties in Abstract state so that it will be shared accross all states
//example : https://www.dofactory.com/net/state-design-pattern

using State_Pattern;

var player = new Player(new InitialState());
player.HandleMove1();
