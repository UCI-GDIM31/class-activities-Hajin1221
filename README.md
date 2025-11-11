# in-class-activities
## Devlogs
### W1


Hello world

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. the rgb values are floats because they're all between 0.0 and 1.0, meaning they must be floats because they're all fractional values
2. the bounce variable is an int because you can't get a fractional bounce
3. It was missing a semicolon

## Open-Source Assets
### W3
 (we are table 2)
(rhythm game method)

The method should return a boolean and take a float as a parameter. We're assuming the float/range that contains the time the player was supposed to hit the button exists somewhere else in the class, and this method would take the float for when they hit the button and compare it with that value, and return either true or false. 

metaphor

Classes are like categories and class components are like things within the category. For example the "animal" category/class would have cats, dogs, horses etc (the items in the category) which would represent the class components. 

The reason the balls turn white after bouncing so many times is because (ok so I think this is it idk) the color values are in hex, and every hex code has a corresponding number in binary. Every time we multiply this number by 1.5 the number increases, making the hex code get "closer" to the highest number you can get in 6 digit hex which is ffffff, which is also pure white. hence why after enough bounces the balls turn white.



### W4
(table 2)
line 5- declares a new float member vairable called _moveSpeed and sets its value to 1.0f
line 22- declares a new float variable called translation and sets its value to the veritcal position of the object (I think it's itself) and multiplies it by a set speed and the number of frames that have passed
line 25 - uses the translation variable to move the object's vertical position by that amount


(individual)
1. we added rigidbodies to both the cat and the ball and made the box collider on the goal a trigger. This is because the cat and ball have to move around, and the ball has to be detecting collisions. we left the goal a trigger because the ball needs to pass through it and we need to use the contact between the ball and the goal to trigger something
2. It didn't work at first because I put the part where you change the timer in the goalMade instead of using the update method. So I changed it. Also I accidentally called the Play() method but it wasnt inside any scopes so it didn't work.

### W5
(table 2)
I need a one sentence summary of a transform vs a vector 3
A: The transform is a vector 3 that has the objects position. a vector 3 is the datatype

Notes for group assigment
The plan:
-create a target transform variable and a deer gameobject
-make a vector3 variable called destination
-Use the NavMeshAgent at the start to create a desination
-Use the destination to move the deer towards the target by getting the NavMeshAgent and updating the position each frame

(smth useful) if you call multiple game objects in update, you can't guarantee a specific order they're called
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 


### W6
table 2
(Romarick and I were doing the unity engine section)
https://docs.google.com/document/d/1g257orHX8bQNaC57k1DMqCDIpAd95jDwpQPqJiA4ks8/edit?tab=t.0 


planning code:
we need:
-speed variable
-location of cat (Vector3)
-location of bat(Vector3)
 

 We ended up having to figure it out as we did it


 Partner Assigment
1. Notes:
-Create GameObject for the player
-Create float for speed
-Create a void method where the bat stop, stopping the bat.
-Create a void method where the bat pursues the player, setting the player transform to the give transform.
-Create a Update method that translate the bat to the player


### W7

https://docs.google.com/document/d/1G_ZSCA2-UVtHll1uaPGUIZ9OZg3-oBIxvR5bJl7Vl6k/edit?tab=t.0 
table 2
I was doing the physics section w Romarick

