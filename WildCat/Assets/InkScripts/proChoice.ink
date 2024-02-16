
VAR clean_path = false
VAR full = false

===getup===
*[Take a shower]
    ~inventory = inventory + shower
 //   ~addedEvent(100)
    ->getup
*[Eat Poptart]
    ~inventory = inventory + poptart
    ~full = true
  //  ~addedEvent(75)
    ->getup
*[Head out]
    ->van


===van===
You make it to the van
 {inventory has shower: ->van.clean}
       
    *[Open front passenger door]
    //    ~addedEvent(50)
        Man you stick get in the back
        **[Get in back seat]
            ->skatespot
   
= clean
     *[Open front passenger door and get in]
    //    ~addedEvent(100)
        ~clean_path = true
            ->skatespot
===skatespot===
* go to the 3 stair
    **gap the stairs
        ->skatespot.gap
   
= gap
    *[easy ollie]
    //    ~addedEvent(75)
        {clean_path: you land clean and roll away}
        {not clean_path: you land a bit sketchy}
            ->skatespot.gap
    *[middle kickfilp]
     //   ~addedEvent(75)
        {clean_path: you land clean and roll away}
        {not clean_path: you bail out and now your not feeling to confident}
            ->skatespot.gap
    *[hard treflip]
     //   ~addedEvent(100)
        {clean_path: you land clean and roll away. Eveyone is impressed}
        {not clean_path: you bail and wipe out this time}
            ->skatespot.gap
*->
    {clean_path: nice man lets go to the miniram->skatespot.miniramp}
        {not clean_path: i think you need more time here. catch up with us later ->skatespot.rail}

= rail
    *[50-50 grind]
      //  ~addedEvent(0)
        {full: you land clean and start to feel better}
        {not full: you land it but almost bailed}
            ->skatespot.rail
    *[boardslide]
      //  ~addedEvent(50)
        {full: That one was nice! your confidence is coming back}
        {not full: you miss the rail and rack your manhood}
        ->skatespot.rail
    *[smith grind]
      //  ~addedEvent(100)
        {full: Wow, you might have gotten a spot on the team if someone saw that one}
        {not full: you miss the rail again and hurt your arm badly}
        ->skatespot.rail
*->
    {full: ok now we are getting somewhere. lets go catch up to the boys ->skatespot.miniramp}
    {not full: you are hurt and embarrassed. time to go home ->END}
= miniramp
Hey man nice to see you over here.
Are you ready to show us what you got now?
    *[Oh yea]

You roll up to the miniramp.
Its your time to shine.
 ** [drop in]
 //   ~addedEvent(100)
    ***[gap the transition]
   //     ~addedEvent(100)
        ****[add kickfilp]
    //        ~addedEvent(100)
            you landed smothly and the boys rush over
        ->wrapup
        ****[add a grab]
     //       ~addedEvent(100)
            you landed smothly and the boys rush over
        ->wrapup
    ***[air straight up for speed]
    //    ~addedEvent(100)
        ****[come back and hit an indie 360]
     //       ~addedEvent(100)
        ->wrapup
        ****[come back and hit a double kickflip]
     //       ~addedEvent(100)
        ->wrapup
 ** [ollie in] 
 //   ~addedEvent(100)
    ***[gap the transition]
 //       ~addedEvent(100)
        ****[add kickfilp]
  //          ~addedEvent(100)
            you landed smothly and the boys rush over
        ->wrapup
        ****[add a grab]
  //          ~addedEvent(100)
            you landed smothly and the boys rush over
        ->wrapup
    ***[air straight up for speed]
 //       ~addedEvent(100)
        ****[come back and hit an indie 360]
 //           ~addedEvent(100)
        ->wrapup
        ****[come back and hit a double kickflip]
 //           ~addedEvent(100)
        ->wrapup
 ===wrapup===
 Man that was crazy. Do you want to join BAKER?
 * You know it!
// ~addedEvent(100)
// ~addedEvent(-1)
    Nice can't wait to skate some compitions with you.
 ->END
 *Naw, i think i still need some practice
// ~addedEvent(0)
// ~addedEvent(-1)
    Thats alright you got our number now. Just hit us up to skate sometime. 
 ->END
    
