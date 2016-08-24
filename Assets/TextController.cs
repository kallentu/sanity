using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {
		mountain, caveNone, survivalNone, tonightNone, cousinNone, comeWith, tomorrowNone, tomorrowNone2, eatFood, eatFood2, cottage, openDoor, walkUpstairs, lookAround, takeFood, takeMoney, refuseLeave, 
		leave, insult, caveAlive, outsideAlive, insideAlive, tonightAlive, tonightAlive2, keepGoing, lookBehind, genDead, tomorrowAlive, tomorrowAlive2, breakWindow, walkAround, greetSoonai, kickSoonai, 
		caveSoonai, outsideSoonai, insideSoonai, knowGen, knowSoonai, survivalSoonai, survivalSoonai2, incidentSoonai, saveSoonai, saveSoonai2, saveGen, saveGen2, holdOn, holdOn2, stabSoonai, tellSoonai, 
		yellHelp
		};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.mountain;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.mountain) 
		{
			mountain();
		
		}
		else if (myState == States.caveNone) 
		{
			caveNone();
		
		}
		else if (myState == States.survivalNone) 
		{
			survivalNone();
			
		}
		else if (myState == States.tonightNone) 
		{
			tonightNone();
			
		}
		else if (myState == States.cousinNone) 
		{
			cousinNone();
			
		}
		else if (myState == States.comeWith) 
		{
			comeWith();
			
		}
		else if (myState == States.tomorrowNone) 
		{
			tomorrowNone();
			
		}
		else if (myState == States.tomorrowNone2) 
		{
			tomorrowNone2();
			
		}
		else if (myState == States.eatFood) 
		{
			eatFood();
			
		}
		else if (myState == States.eatFood2) 
		{
			eatFood2();
			
		}
		else if (myState == States.cottage) 
		{
			cottage();
			
		}
		else if (myState == States.openDoor) 
		{
			openDoor();
			
		}
		else if (myState == States.walkUpstairs) 
		{
			walkUpstairs();
			
		}
		else if (myState == States.lookAround) 
		{
			lookAround();
			
		}
		else if (myState == States.takeFood) 
		{
			takeFood();
			
		}
		else if (myState == States.takeMoney) 
		{
			takeMoney();
			
		}
		else if (myState == States.refuseLeave) 
		{
			refuseLeave();
			
		}
		else if (myState == States.leave) 
		{
			leave();
			
		}
		else if (myState == States.insult) 
		{
			insult();
			
		}
		else if (myState == States.caveAlive) 
		{
			caveAlive();
			
		}
		else if (myState == States.outsideAlive) 
		{
			outsideAlive();
			
		}
		else if (myState == States.insideAlive) 
		{
			insideAlive();
			
		}
		else if (myState == States.tonightAlive) 
		{
			tonightAlive();
			
		}
		else if (myState == States.tonightAlive2) 
		{
			tonightAlive2();
			
		}
		else if (myState == States.keepGoing) 
		{
			keepGoing();
			
		}
		else if (myState == States.lookBehind) 
		{
			lookBehind();
			
		}
		else if (myState == States.genDead) 
		{
			genDead();
			
		}
		else if (myState == States.tomorrowAlive) 
		{
			tomorrowAlive();
			
		}
		else if (myState == States.tomorrowAlive2) 
		{
			tomorrowAlive2();
			
		}
		else if (myState == States.breakWindow) 
		{
			breakWindow();
			
		}
		else if (myState == States.walkAround) 
		{
			walkAround();
			
		}
		else if (myState == States.greetSoonai) 
		{
			greetSoonai();
			
		}
		else if (myState == States.kickSoonai) 
		{
			kickSoonai();
			
		}
		else if (myState == States.caveSoonai) 
		{
			caveSoonai();
			
		}
		else if (myState == States.outsideSoonai) 
		{
			outsideSoonai();
			
		}
		else if (myState == States.insideSoonai) 
		{
			insideSoonai();
			
		}
		else if (myState == States.knowGen) 
		{
			knowGen();
			
		}
		else if (myState == States.knowSoonai) 
		{
			knowSoonai();
			
		}
		else if (myState == States.survivalSoonai) 
		{
			survivalSoonai();
			
		}
		else if (myState == States.survivalSoonai2) 
		{
			survivalSoonai2();
			
		}
		else if (myState == States.incidentSoonai) 
		{
			incidentSoonai();
			
		}
		else if (myState == States.saveSoonai) 
		{
			saveSoonai();
			
		}		
		else if (myState == States.saveSoonai2) 
		{
			saveSoonai2();
			
		}
		else if (myState == States.saveGen) 
		{
			saveGen();
			
		}
		else if (myState == States.saveGen2) 
		{
			saveGen2();
			
		}
		else if (myState == States.holdOn) 
		{
			holdOn();
			
		}
		else if (myState == States.holdOn2) 
		{
			holdOn2();
			
		}
		else if (myState == States.stabSoonai) 
		{
			stabSoonai();
			
		}
		else if (myState == States.tellSoonai) 
		{
			tellSoonai();
			
		}
		else if (myState == States.yellHelp) 
		{
			yellHelp();
			
		}
	
	
	}
	
	
	void mountain () {
		text.text = "Darkness. \n \n" +
			
				"The wind howls in your ear, freezing the corners of your lips. You open your " +
				"eyes and snow splatters your face as white mountainous views start to appear. You sit up " +
				"and see a damp cave in the distance. There is also what you make out to be a small cottage. " +
				"The rushing blizzard is getting more violent. You remember nothing from your past, not even " +
				"who you are. Your tattered snow gear will not suffice. \n\n" +
				
				"(Note: There are multiple endings and your choices affect your outcome.)\n\n" +
				
				"Press A to move towards the cave \n" +
				"Press O to move towards the cottage.";
				
		
		if (Input.GetKeyDown (KeyCode.A))
		{
			myState = States.caveNone;
			
		}
		
		if (Input.GetKeyDown (KeyCode.O))
		{
			myState = States.cottage;
			
		}
	
	}
	
	
	
	
	
	
	
	#region Cave None
	
	void caveNone () {
		text.text = "After a few hours you reach the cave, sweating and tired. Flat rocks with a small layer of snow lie under the overhang of a large bounder. You walk into the cave, at first noticing how dark and damp it " +
					"was. Yet in a short minute, you see light and a slim body next to a fire. The woman looks up, she seemed friendly, but worried about some other thing on her mind.\n\n" +
					
					"'Well, it's been a while since I've seen any humans around here. I thought all the prisoners on the trip died except me and maybe that source of the crazy laughter I hear by the cottage. Nonetheless, " +
					"my name is Gen. Come, make yourself at home.'\n\n" +
					
					"You took an instant liking to her and comfortably sat down on the stone by the fire. Gen stares at you in bewilderment as if you're her last hope. She looks down sadly, but shakes it off.\n\n" +
					"'My food supplies are quite low these days, but please take something to eat. I insist. I can go hunting if need be... although I'm not sure what will still be out there with the predicted upcoming ice age.'\n\n" +
		
					"Press S to talk about survival.\n" +
					"Press E to eat food." ;
					
		if (Input.GetKeyDown (KeyCode.S))
		{
			myState = States.survivalNone;
			
		}
		
		if (Input.GetKeyDown (KeyCode.E))
		{
			myState = States.eatFood;
			
		}
	}
	
	
	void survivalNone () {
		text.text = "You ask about her survival in the cave and learn that she is a wanted woman from the nearby city.\n\n" +
		
					"'I swear I'm not a murderer or anything, the reason I'm here is because I have the royal blood of the previous ruling family in Karkal. It's a complicated history with long unwinding fights " +
					"and I guess King Toron wanted no more of my family. He tried to murder or imprison my siblings and cousins. I do not know how many are still alive, besides my cousin who hid before the " +
					"massacre began.', Gen takes a long time to drink water before continuing, 'Long story short; Toran ordered a bunch of prisoners including myself to be thrown in the wilderness to die.'\n" +
					"Gen gives a big hearty laugh then her face solidifies, 'I made shelter here and I'm able to help myself. The only thing that concerns me is the ice age. It's predicted to come soon and the amount " +
					"of snow that will fall is unsettling. I cann- we cannot stay here for much longer, and I knew I couldn't survive the trek alone so I never left the cave... but now that you're here, we can make the journey " +
					"together. So what do you say for getting out before we get engulfed in ice and snow? Shall we travel to Karkal tonight or tomorrow morning?'\n\n" +
		
					"Press T to agree to begin travelling tonight.\n" +
					"Press M to agree to begin travelling tomorrow morning." ;
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.tonightNone;
			
		}
		
		if (Input.GetKeyDown (KeyCode.M))
		{
			myState = States.tomorrowNone;
			
		}
	
	}
	
	#region Gen Tonight
	void tonightNone () {
		text.text = "The two of you pack rapidly, hurrying to begin the journey by sundown. Gen looks determined, sometimes flashing her liking for revenge. You carry half of the supplies and Gen carries the other half. " +
					"You notice how the wind blows harder and faster at night. Blackness once again sets across the mountain, but Gen prepared with makeshift lamps that won't go out.\n" +
					"Gen and you begin the long trek towards the city. She leads since she knows the direction to Karkal.\n" +
					"Many hours pass, and the snow level has already risen up to your knees. In the distance, Gen stops and waits for you to catch up.\n\n" +
					"'I see the city... I'm just... I don't know. I'm going to die if I set foot in the city. King Toran is going to find me. I have to go live with my cousin. I'm sure he will provide me with shelter " +
					"and he lives in a nearby area...' \n\n" +
					
					"Press C to tell her to go live with her cousin. \n" +
					"Press Y to ask her to come with you instead. " ;
		
		if (Input.GetKeyDown (KeyCode.C))
		{
			myState = States.cousinNone;
			
		}
		
		if (Input.GetKeyDown (KeyCode.Y))
		{
			myState = States.comeWith;
			
		}
	}
	
	void cousinNone () {
		text.text = "Gen points you towards the city and you make your way there. Meanwhile she endures the road to her cousin's house.\n" +
					"Once you reach the city, you find your way around. You get prepared for shutdown mode to bear through the ice age with the other citizens. You never heard from Gen again, not knowing her condition " +
					"or if she's even alive. You hope she is somewhere where she can be happy and healthy. Everything is peaceful within the city and you are content. \n\n" +
					
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	void comeWith () {
		text.text = "You ask Gen to trust you and to join you in the city. You promise you will protect her and eventually, Gen and you will get new identities. She looks at you tearfully, and nods. \n\n" +
		
					"Reaching the city, at first nobody notices anything strange. You keep a low status and many years into the ice age lockdown protocol the city had, there were no problems.\n" +
					"However, one day as you were walking with Gen on the streets, a man with green and red hair shot her and ran away. She died that night.\n\n" +
					
					"You never found her assassinator, and for now you live in terrible regret and anguish. Believing your choices caused her death, you never forget Gen. \n\n" +
		
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	#endregion
	
	#region Gen Tomorrow Morning
	void tomorrowNone () {
		text.text = "You sleep by the fire and Gen sleeps by your side. The night is short and sleep was only a way to make time go faster. Gen packs the supplies and the two of you set off on the way towards the " +
					"city. Vast mountains confuse you as you travel, and you wonder if you were a prisoner on the trip to the mountains just like Gen. You sigh, not knowing who you are or what caused you to be in " +
					"this exact situation. However, you are thankful for meeting Gen or else you may not even be alive right now. The city appears in your view, hazy and snowblown yet strong and fortified. Karkal is a " +
					"civilized and industrialized city. Gen looks at you, wanting confirmation or reassurance to move forward. You pat her on the back and continue onwards.\n\n" +
					
					"Press Space to continue." ;
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.tomorrowNone2;
			
		}
		
	}
	
	
	void tomorrowNone2 () {
		text.text = "Once you reach the Karkal, the major freeze is very close and the city is bracing for the ice age lockdown they had planned. Karkal was a beautiful city, organized with every citizen understanding " +
					"their role in society. Gen and you agree to use aliases to keep her safe from those who want to kill her. You end up staying with her for safety and since you did not know anyone else in Karkal. \n\n" +
					"Over the years, you both settle into a nice home and live happily. The city is calm and full of opportunities. \n\n" +
					
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	#endregion
	
	#region Eat Food Death
	void eatFood () {
		text.text = "You pick from the last piece of meat she butchered just this morning. You grab the leg and roast it over the fire. After saying thanks to Gen, you sit in silence, nibbling on the first piece of food " +
					"that you feel like you've had in days.\n" +
					"Gen stands up abruptly, brushing off bits of food from her damaged brown jacket, 'There won't be enough meat for tomorrow and there are a few hours before dusk so I will go out quickly to hunt. " +
					"I'm not sure what wildlife is left due to the storm, but might as well make good use of time now. Don't worry, I'll be back in no time.'\n" +
					"Gen grabs her adapted hunting tools and a knife she carved herself. She walks to the entrance of the cave and smiles at you before she disappears into the white sky. \n\n" +
					
					"Press Space to continue." ;
			
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.eatFood2;
			
		}
		
	}
	
	
	void eatFood2 () {
		text.text = "You wait for many hours. Well into the night, you pace around nervously. You look out of the entrance of the cave and you see no signs of Gen. Her footprints blown away by the force of the storm. " +
					"You walk back inside and wait. Days go by and you haven't seen any signs of her. Gen is probably dead. You lie next to a fire that you keep relighting, and you know that death lingers close by. \n\n" +
					"Wolves, bears, coyotes. They can all kill you, but death is never certain. The blizzard on the other hand gives you no room for a fight. You tire out with no food, yet you know you cannot go outside since " +
					"you as well will perish like Gen. Meanwhile, the snow buries you alive in the underground cave. You see the last bit cover the top of the entrance as your eyes gradually shut.\n\n" +
					
					"There are some things that you cannot escape the death of. \n\n" +
					
					"Press Enter to play again.";
			
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	
	#endregion

	#endregion
	
	
	
	
	
	
	
	
	
	
	void cottage () {
		text.text = "The rocks nearby crumble down the slope as you reach the cottage. It was small and tattered, the roof ripped from the house. The cottage was entirely made of wood and the only things that seemed to be " +
					"whole were the windows and the door. Every other part of the cottage was in ruins from the storm.\n" +
					"The blizzard was growing stronger, and you need to enter the house to get to safety. \n\n" +
		
					"Press O to open the door.\n" +
					"Press B to break the window to enter." ;
		
		if (Input.GetKeyDown (KeyCode.O))
		{
			myState = States.openDoor;
			
		}
		
		if (Input.GetKeyDown (KeyCode.B))
		{
			myState = States.breakWindow;
			
		}
	}
	
	#region Open Door
	void openDoor () {
		text.text = "The cottage is enormous; it feels larger on the inside. Around the corner is a spiral staircase and on the other side there is a torn apart couch. There are multiple drawings on the " +
					"table and a broken television is left on the floor. \n\n" +
		
					"Press W to walk upstairs.\n" +
					"Press L to look around." ;
		
		if (Input.GetKeyDown (KeyCode.W))
		{
			myState = States.walkUpstairs;
			
		}
		
		if (Input.GetKeyDown (KeyCode.L))
		{
			myState = States.lookAround;
			
		}
	}
	
	
	void walkUpstairs () {
		text.text = "You walk upstairs and every door is locked up. The bathroom has a cracked mirror and you're starting to feel uncomfortable. \n\n" +
		
					"Press Space to go back downstairs.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.openDoor;
			
		}
		
		
	}
	
	
	void lookAround () {
		text.text = "Walking around, you notice a stack of bills on the table. There is also some dried meat on the table, a few steps away.\n\n" +
			
					"Press F to take the food.\n" +
					"Press M to take the money." ;
		
		if (Input.GetKeyDown (KeyCode.F))
		{
			myState = States.takeFood;
			
		}
		
		if (Input.GetKeyDown (KeyCode.M))
		{
			myState = States.takeMoney;
			
		}
	}
	
	
	void takeFood () {
		text.text = "You take the meat and starting eating. Almost instantly, you feel a pressure on your side. You look down and see blood. You panic and fall over. In the darkness of the house, you see a silhouette " +
					"walking away from you. The figure cackles and grumbles. Slowly, you bleed out and your world turns dark again. \n\n" +
		
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	
	
	
	void takeMoney () {
		text.text = "You grab the pile of bills and you wonder why anyone would need money in the middle of nowhere. You laugh, thinking that money is the last thing on your mind right now. Behind you, a high cackle startles " +
					"you. You turn around and come face to face with a man with bright red and green hair. He has an odd smile.\n\n" +
					"'I doubt you need the money sir. Ha ha ha. My name is Soonai, now if you would be so kind, please, leave this place right now.'\n" +
					"The man cocks his head towards the door. You try explaining how you just need a place for the night and you will go as soon as possible.\n\n" +
					"The man pulls out a knife, 'I don't know what your true intentions are. Leave. Now.'\n\n" +
			
					"Press R to refuse to leave.\n" +
					"Press L to leave." ;
		
		if (Input.GetKeyDown (KeyCode.R))
		{
			myState = States.refuseLeave;
			
		}
		
		if (Input.GetKeyDown (KeyCode.L))
		{
			myState = States.leave;
			
		}
	}
	
	
	
	void refuseLeave () {
		text.text = "You refuse to leave, knowing that the outside means death anyways. You tell him you mean no harm to him. Soonai paces around, mumbling and swinging his knife around.\n" +
					"He turns to you and looks you in the eyes. His eyes are cold and still. Soonai charges towards you and plunges his knife into you.\n\n" +
					"'I don't trust you.' was the last thing you heard before blood rushed to your ears. \n\n" +
		
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	
	void leave () {
		text.text = "You grumble and leave the house reluctantly. Soonai laughs as he pushes you out. As you walk away, you hear him yelling at you not to come back and how you're not welcome anywhere in the vicinity. \n\n" +
					
					"Press I to throw back an insult.\n" +
					"Press C to go to the cave." ;
		
		if (Input.GetKeyDown (KeyCode.I))
		{
			myState = States.insult;
			
		}
		
		if (Input.GetKeyDown (KeyCode.C))
		{
			myState = States.caveAlive;
			
		}
	}
	
	
	void insult () {
		text.text = "You throw your fist in the air and swear nonsensically at him. If you die in your journey to the cave, you swear you'll hunt him down and haunt him as a ghostly apparition.\n\n" +
			
					"Press Space to go to the cave once you calmed down.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.caveAlive;
			
		}
		
		
	}
	
	void caveAlive () {
		text.text = "You arrive at the dark cave. It smells really bad. The scent of blood is in the air, although not specifically human blood or animal blood. You hear noises in the cave, however the storm is growing " +
					"and you need to rest. \n\n" +
			
					"Press C to camp outdoors and stay out of the cave.\n" +
					"Press G to go inside the cave." ;
			
		if (Input.GetKeyDown (KeyCode.C))
		{
			myState = States.outsideAlive;
			
		}
		
		if (Input.GetKeyDown (KeyCode.G))
		{
			myState = States.insideAlive;
			
		}
	}
	
	
	void outsideAlive () {
		text.text = "You decide to camp outside to avoid any dangerous animals inside the cave. At night time, the sky is black and the temperature drops below freezing. You're sure you won't make it to the morning. " +
					"Wolves howl in the distance and you hear small crunching footsteps. The wolves have tracked you down and you have no energy to fight them. You die being mauled to death. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	
	
	void insideAlive () {
		text.text = "You see small slim foot prints in the path to the cave which you decide to follow. Rocks crumble here and there, and you feel as if the cave itself is going to collapse. Light flickers in the crevice of " +
					"the cave. You make a right turn and come face to face with a woman. Her clothes are tattered and she has meat lying around a large fire. She sees you and kindly waves you in.\n" +
					"If only you had this type of welcome at the cottage, you think to yourself.\n\n" +
					
					"She speaks quietly 'Well hi there. I'm Gen. You came at a bad time really. Sit down and eat, but just so you know I will be leaving soon. I've been receiving threats on the base of the cave and " +
					"I really have no time to explain... You can come with me if you want.'\n\n" +
					
					"You nod, you understand her urgency. Yet, nighttime is the worst time to travel especially in such bad weather. She seems to be in a big hurry though.\n\n" +
			
					"Press T to advise her to begin travelling tonight.\n" +
					"Press M to advise her to begin travelling tomorrow morning." ;
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.tonightAlive;
			
		}
		
		if (Input.GetKeyDown (KeyCode.M))
		{
			myState = States.tomorrowAlive;
			
		}
	}
	
	#region Tonight Soonai Alive
	
	void tonightAlive () {
		text.text = "You tell Gen to start travelling today since she seemed to be in a very big rush to get somewhere. The night is dark, but you follow the glimmer of the lamp that Gen holds. You're not sure where " +
					"she is going, but you are starting to regret leaving that cave. Gen stops walking and starts mumbling to herself. You both hear laughter in the distance and wonder if it is just a hallucination.\n" +
					"The laughter doesn't stop anytime soon and you hear it coming closer. In the dark, you feel so vulnerable.\n\n" +
					
					"Suddenly, Gen's lamp gets knocked out of her hand by a dark figure. She screams and you're in shock.  \n\n" +
			
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.tonightAlive2;
			
		}
		
		
	}
	
	
	void tonightAlive2 () {
		text.text = "Gen dies after hearing her blood curdling screams. You stumble to your feet and run wherever you can. The coldness hurts and you find cover under a small rock. You are exhausted and eventually " +
					"your eyes shut in the midst of the distant laughter. \n\n" +
			
					"Press K to keep going after you wake up. \n" +
					"Press L to look behind you after you wake up.";
		
		if (Input.GetKeyDown (KeyCode.K))
		{
			myState = States.keepGoing;
			
		}
		if (Input.GetKeyDown (KeyCode.L))
		{
			myState = States.lookBehind;
			
		}
		
		
	}
	
	
	void keepGoing () {
		text.text = "Every part of your body aches and you awake to the sun shining above you. You spot a city along the horizon, being the only visible thing for miles. You keep moving forward, not looking " +
					"back to the terrors on the mountain. Gen is dead and everything happened all too fast. \n\n" +
			
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.genDead;
			
		}
		
		
	}
	
	
	
	void lookBehind () {
		text.text = "You decide to look behind and see Gen's mutilated body. You see a large pool of blood surrounding her. Horrified, you run faster to the city, knowing that her killer probably will track you down too. \n\n" +
			
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.genDead;
			
		}
		
		
	}
	
	
	
	void genDead () {
		text.text = "Ultimately, you reach the city. The civilization is ruled by a power-hungry man named Soonai. You end up working for him, just like everyone else in Karkal. The city is full of corruption and devastation. " +
					"You live in fear and you have nightmares of Gen's death every single night. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	
	#endregion
	
	
	#region Tomorrow Soonai Alive
	void tomorrowAlive () {
		text.text = "You decide to travel in the morning. The path is long. Rows and rows of mountains cover your view, while fresh snow crunches under your boots. Gen and you get tired, but decide to endure as much as " +
					"possible.\n\n " +
					
					"You reach the city. Large letters greet you at the entrance; 'KARKAL : Population - 2607' \n\n" +
			
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.tomorrowAlive2;
			
		}
		
		
	}
	
	
	void tomorrowAlive2 () {
		text.text = "Gen later finds out that her cousin is the ruler of the city. She thanks you for helping her with the journey and leaves immediately. You never find out much about her and you wonder how she ended up " +
					"on the mountain in the first place.\n\n" +
					
					 "Meanwhile, you hear that Soonai is a wanted man in the city. He is a murderer on the loose. You live in fear, but you find your way in the city. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
	#endregion
	#endregion
	
	void breakWindow () {
		text.text = "You break the window by throwing a rock at it. You jump in and manage to cut your thigh. Your leg is bleeding heavily and you urgently need a first aid kit. You take out a knife in case of any dangers. \n\n" +
		
					"Press W to walk around and see if there is anything that can help your injury.\n" +
					"Press Y to yell for help." ;
		
		if (Input.GetKeyDown (KeyCode.W))
		{
			myState = States.walkAround;
			
		}
		
		if (Input.GetKeyDown (KeyCode.Y))
		{
			myState = States.yellHelp;
			
		}
	}
	
	
	void walkAround () {
		text.text = "A light flickers near the hallway. You make a turn around a corner and seem to reach the kitchen. You come face to face with a pale man with a crazy smile. He had bright red " +
					"and green hair. The man has clothing not suited for the cold weather and seems to be off in his own world. \n\n" +
			
					"Press H to greet him. \n" +
					"Press T to tell him you have no intention to harm him and you just need some help." ;
		
		if (Input.GetKeyDown (KeyCode.H))
		{
			myState = States.greetSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.tellSoonai;
			
		}
	}
	
	
	void greetSoonai () {
		text.text = "You say hello and ask if he can help you as you clutch your leg. The man introduces himself, with no sense of urgency for your state of health. He takes out a knife suddenly and walks around you " +
					"suspiciously. You're nervous and angry. The man has no priorities. He charges at you with the knife with no warning. \n\n" +
			
					"Press K to kick him in the crotch. \n" +
					"Press S to use your knife to stab him in the chest." ;
		
		if (Input.GetKeyDown (KeyCode.K))
		{
			myState = States.kickSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.S))
		{
			myState = States.stabSoonai;
			
		}
	}
	
	
	void kickSoonai () {
		text.text = "You kick him backwards. He begins laughing uncontrollably on the ground then he sits up and introduces himself as Soonai. He shakes your hand and skips to the next room, returning with a makeshift " +
					"aid pack. You stare in confusion, but he doesn't say anything. He heard of a scream down at the cave and wants you to check it out with him. Soonai seemed very intent on finding another crazy " +
					"friend or at least finding out what is in the cave. There is something severely wrong with Soonai, you think to yourself, but you rather not say no to his wishes.\n\n" +
			
					"Press Space to reluctantly travel to the cave with Soonai.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.caveSoonai;
			
		}
		
	}
	
	
	void caveSoonai () {
		text.text = "Soonai warns you about what he has heard in the cave as you are about to go in. Lately, he's been changing from a normal person to one that seemed to have gone absolutely insane. You're not " +
					"sure what to do. The cave offers protection, but it is dark. Meanwhile, staying outside could mean certain doom. \n\n" +
			
					"Press O to stay outside and make a camp near the cave. \n" +
					"Press I to go inside." ;
		
		if (Input.GetKeyDown (KeyCode.O))
		{
			myState = States.outsideSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.I))
		{
			myState = States.insideSoonai;
			
		}
	}
	
	
	void outsideSoonai () {
		text.text = "You choose to stay outside and are willing to bear down the conditions. However, Soonai is sneezing up a storm and he insists it's a condition for when he's on the verge of hyperthermia. Soonai " +
					"changes his mind about staying outside and advises you otherwise now. You grumble, but agree with his choices. He was the reason you're outside anyways. \n\n" +
				
					"Press Space to drag the half-sneezing-half-laughing Soonai inside the cave.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.insideSoonai;
			
		}
		
	}
	
	
	void insideSoonai () {
		text.text = "You walk into the cave. It was really quiet, occasionally hearing a small insect or rodent. You hear the crackle of a fire and as you make a turn you see a woman in a long brown jacket. " +
					"She doesn't even bother looking at you, almost as if she expected your company. The woman waves you both in and introduces herself. \n\n" +
					
					"'Hello boys, I'm Gen. What brings you two here?'\n\n" +
					
					"You feel the twitching of Soonai by you and you sense that he is starstruck. Soonai and Gen get along well and he calms down enough to stay quiet. You are glad to have found a sane person at " +
					"last, but you wonder how she or Soonai got into their respective situations. \n\n" +
			
					"Press G to ask Gen about herself.\n" +
					"Press S to ask Soonai about himself.\n" +
					"Press T to talk about your next steps of survival with the group. (Advances the story, get to know them if you don't want to miss anything)" ;
		
		if (Input.GetKeyDown (KeyCode.G))
		{
			myState = States.knowGen;
			
		}
		
		if (Input.GetKeyDown (KeyCode.S))
		{
			myState = States.knowSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.survivalSoonai;
			
		}
	}
	
	
	void knowGen () {
		text.text = "You ask Gen about herself and what her story is. \n\n" +
		
					"'Well, I was a member of the royal family of the city, Karkal. Until lately when another family came to rule, I lived happily in the city and was to be crowned Princess in a few months. The new king, " +
					"King Toran rounded up my entire family and had them slaughtered. I was lucky enough to be exiled to the mountains. He ordered a prison truck to carry multiple prisoners including myself to the " +
					"mountains to be thrown out and abandoned. King Toran claimed that there wasn't enough room in the prisons to keep us. Bull shit.\n" +
					"Nonetheless, I found a cave and managed on my own until you guys came. I'm more interested in your story.'\n" +
					"You brush it off, but Soonai is excited to tell what happened, wanting to impress Gen as much as he could. You roll your eyes and continue the conversation. \n\n" +
				
					"Press S to ask Soonai about himself.\n" +
					"Press T to talk about your next steps of survival with the group. (Advances the story, get to know them if you don't want to miss anything)" ;
		
		if (Input.GetKeyDown (KeyCode.S))
		{
			myState = States.knowSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.survivalSoonai;
			
		}
		
	}
	
	
	void knowSoonai () {
		text.text = "You turn to Soonai and ask him about how he ended up at the cottage. He gets up and grunts. He walks around trying to make sense of his words. \n\n" +
					"'I'm not sure... I can't remember much. I was at the house for so long, living off of the supplies in it. I was at an asylum before, but I don't know. Some man came for me one day and I never trusted " +
					"anyone anymore,' he curls up like a child.\n\n" +
					
					"Now you understand why he was so suspicious of you and how there must be a reason he was put in an asylum. You decide it would be best to change the subject.\n\n" +
			
					"Press G to ask Gen about herself.\n" +
					"Press T to talk about your next steps of survival with the group. (Advances the story, get to know them if you don't want to miss anything)" ;
		
		if (Input.GetKeyDown (KeyCode.G))
		{
			myState = States.knowGen;
			
		}
		
		if (Input.GetKeyDown (KeyCode.T))
		{
			myState = States.survivalSoonai;
			
		}
		
	}
	
	
	void survivalSoonai () {
		text.text = "You ask about the blizzard. Gen says that the storm is due to an upcoming ice age and unfortunately, only the city nearby has sufficient shelter to last through it. \n\n" +
		
					"The three of you agree to go to the city once morning comes. Soonai spends the night humming a tune, while Gen fell asleep on his shoulder. You're confused at how the two of them are so compatible.\n" + 
					"Eventually, night falls and your body is aching to lie down. Your eyes droop off into a misty world with flying ships and dancing stars. \n\n" +
				
					"Press Space to wake up after sleeping a long night.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.survivalSoonai2;
			
		}
		
	}
	
	
	void survivalSoonai2 () {
		text.text = "Everyone wakes up at the crack of dawn and Gen keeps everyone awake with stories of the city. She explains that the city of Karkal has citizens whose roles in society are assigned to them. Everyone in the " +
					"city is assigned to a few different focus areas, however they are many that go through a system in order to choose what they do within Karkal.\n " +
					"The city makes you think about where you would fit in, or if you would fit in at all. \n\n" +
					
					"Nevertheless, you pack your bags and both Soonai and Gen are ready for travel. \n\n" +
			
					"Press Space to start the journey down the mountain to the city Gen speaks of." ;
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.incidentSoonai;
			
		}
		
	}
	
	
	void incidentSoonai () {
		text.text = "Hours pass by quickly and you know you have already traveled a couple of miles. You are climbing down a steep cliff. The bottom seems to be endless and the road you're on is only a few meters wide. " +
					"Rocks and snow tumble down while white flakes buzz around your face. A side of the cliff crumbles from the weight of snow and both Soonai and Gen tumble.\n\n " +
					
					"Do you grab Soonai, grab Gen, or hold on to the nearest rock and hope they can reach you? \n\n" +
			
					"Press S to grab Soonai. \n" +
					"Press G to grab Gen. \n" +
					"Press H to hold on to the nearest rock." ;
		
		if (Input.GetKeyDown (KeyCode.S))
		{
			myState = States.saveSoonai;
			
		}
		
		if (Input.GetKeyDown (KeyCode.G))
		{
			myState = States.saveGen;
			
		}
		
		if (Input.GetKeyDown (KeyCode.H))
		{
			myState = States.holdOn;
			
		}
		
	}
	
	
	void saveSoonai () {
		text.text = "Quickly, you grab Soonai's jacket and pull him towards you as you move aside to safety. He laughs and giggles, but you can see terror in his eyes. Gen screams and " +
					"falls down the cliff side, and hitting the rocks and trees at the bottom. Her scream echoes in your head. \n\n" +
					
					"Soonai crumbles down in silence. You watch the mountainous void as if Gen is going to reappear. You shake Soonai and find him sobbing. He waves you away and you give him a moment. You tell him the " +
					"city is close and you have to move. \n\n" +
				
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.saveSoonai2;
			
		}
		
	}
	
	
	void saveSoonai2 () {
		text.text = "The two of you reach the city of Karkal and join them in their lockdown. Soonai lost some of his craziness once Gen died, but you still maintained a strong friendship with him. You become well " +
					"accustomed to the city and the people in it. You are thankful that you met Gen. Soonai made a grave for her and you both visit and have a moment of silence. The city is well and lively. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	
	void saveGen () {
		text.text = "Your hands reach out to Gen and she holds on to you. She reaches your side, panting heavily. Soonai holds on to Gen for a mere second, but he slips and tumbles downwards. He screams and Gen runs to " +
					"the edge of the cliff. You hold her back, but she is screaming in tears. The avalanche stops and Gen is devastated. She paces around and shouts at herself. You decide to give her a few minutes. \n\n" +
					
					"At last, you tell her that time is ticking and that the blizzard is getting stronger. Gen refuses to move and tells you to go to Karkal alone. She wants to find Soonai and bury him. \n" +
					"You're not sure what made Gen feel that way, but possibly she loved Soonai more than anyone could have. You hug her and attempt to persuade her to come. Alas, she's more stubborn than you are and you " +
					"decide to continue walking towards Karkal alone.\n\n" +
			
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.saveGen2;
			
		}
		
	}
	
	
	void saveGen2 () {
		text.text = "The life in the city was peaceful, yet you missed the company of Soonai and Gen. You never heard from Gen again, but suspicious stories popped up all over the city about a crazy women living the in " +
					"mountains with a dead corpse. The children supposedly hear her laughter as they play close to the outside. The lockdown created a sheltered area for residents in the city, and you're not sure how much " +
					"outside of the city one can hear, especially with the storm being so unbearable. You live the rest of your days within city limits, never to venture outside to the mountains again. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	
	void holdOn () {
		text.text = "You rapidly cling on to the nearest rock, while Soonai and Gen both catch your jacket and your arm. Everyone holds on for a minute until the avalanche ends and then you let go once it was safe. " +
					"Soonai is out of breath and Gen sits down, shellshocked at how close she was to death. You peek over the edge and gulp, knowing that nothing would have survived going down the mountain. \n\n" +
					
					"Soonai starts laughing, for some reason you're not sure of. It doesn't matter, however, because soon after Gen begins laughing too and the three of you are laughing like lunatics on the side of a " +
					"mountain. Everyone sits down for a second to take in the view. Life is so short and is taken forgranted until you are on the verge of death. \n\n" +
				
					"Press Space to continue.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.holdOn2;
			
		}
		
	}
	
	
	void holdOn2 () {
		text.text = "After a couple more hours of treading through heavy snow, Soonai, Gen and you reach Karkal. Everyone is safe and you are thankful for that. Gen uses a different name in case anyone wants to harm her. " +
					"Soonai and her end up together and live in a quiet neighbourhood. Soonai's still mildly insane, but Gen loves him so it doesn't matter. You visit them often and you are quite happy with your " +
					"own place. The city is huge and you're very glad to have good friends by your side.\n\n" +
				
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	
	
	void stabSoonai () {
		text.text = "The man gets too close and you instinctively kill him before he stabs you. He chokes and falls down, a tear streaking down his smiling face. You sigh, his large grin creeps you out and was more than " +
					"enough to give you nightmares. You decide to use the supplies the man had in the house. You wrap yourself up and hope you can leave the ghost house as fast as possible and not bleed out. \n\n" +
			
					"Press Space to hurry out of the house and limp to the cave as your last resort.";
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myState = States.caveNone;
			
		}
		
	}
	
	
	void tellSoonai () {
		text.text = "You tell the man you won't harm him, you just need something to stop the bleeding. The man goes berserk and runs at you with the knife. He does not stop and stabs you multiple times. \n\n" +
		
					"The man yells, 'EVERYONE TELLS ME THAT. YOU ARE GOING TO HURT ME. YOU ARE GOING TO HURT ME LIKE EVERYONE ELSE DID'. \n" +
					"His voice drowns out as your head fills with blood. You die from your multiple stab wounds. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
	}
	
	
	
	
	void yellHelp () {
		text.text = "You scream for help. Nobody comes and you bleed out. You feel your heart beating and you begin to panic. You're so desperate and you yell one last time for anyone to come and help you. " +
					"As you fade away, you hear heavy footsteps in the distance, followed by a slow, grumbly laugh. You die. \n\n" +
			
					"Press Enter to play again.";
		
		if (Input.GetKeyDown (KeyCode.Return))
		{
			myState = States.mountain;
			
		}
		
		
	}
}
