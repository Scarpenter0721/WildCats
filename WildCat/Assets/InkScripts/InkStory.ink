INCLUDE proChoice.ink
INCLUDE skateAlone.ink
//EXTERNAL addedEvent(moral)
//EXTERNAL Artwork(charName)



VAR hour = 6
VAR current_path_positive = false
LIST game_object = shower, poptart
LIST inventory = skateBoard

// Situation 1
//knot
->begin
===begin===
//{Artwork("clock")}
#IMAGE: images/Clock.jpg
{hour > 9: ->awake}

You wake up at {hour}:00AM
// choices
    + [Hit the snooze button]
        ~hour = hour + 1
  //     ~addedEvent(50)
//divert
        ->begin
    * [Get off the couch]
        ~current_path_positive = true
            ->awake

// Fallback choice (Exicutes once no more choices are used)
/*
*->
    all choices used
    ->END
*/       
//knot     
===awake===

    {current_path_positive: ->getup}
    {not current_path_positive: ->skatealone}
        ->END