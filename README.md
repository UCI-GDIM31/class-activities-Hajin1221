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


- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 