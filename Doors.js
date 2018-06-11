//problem
//100 doors in a row all closed
//pass by the doors 100 times
//first time open each door
//second time visit every 2nd door and close the door
//3rd time visit every 3rd door and change the door (close if open or open if closed)
//4th time visit every 4th door and change the door
///etc.,
//What state are the doors in after the last pass? 
//Which doors are open and which are closed?

var doors =[];
for (var i =0; i <100; i++)
  doors[i]=false;
for(var i=1; i <=100; i++)
  for (var i2=i-1; i2<100; i2+=i)
    doors[i2]=!doors[i2];
  for(var i=1; i <=100; i++)
    console.log("Door %d is %s", i, doors[i-1]?"open": "closed")
    

//uses square roots
Array.apply(null, { length: 100})
    .map((v,i) => i + 1)
    .forEach(door => {
        var sqrt = Math.sqrt(door);

        if (sqrt === (sqrt | 0)) {
            console.log("Door %d is open", door);
        }
    });

    