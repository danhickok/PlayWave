# PlayWave
## A quick and dirty use of .NET to play a .WAV file from the command line

Have you ever run into this?  You've written a .BAT file in Windows that will perform
a bunch of tasks for you while you're doing something else important (like watching
YouTube).  Well, that's great - but now you want the batch file to tell you
when it's done.

So you tried adding "echo ^G" to the end of the file, so it plays the system chime.
And that works, but it's kinda wimpy.  And it doesn't even play when your video is on
(or maybe you don't even notice it).

So you think, wouldn't it be nice if it could play some sort of sound file when it's
finished.  Ah, but how to do that?

Well, here is a solution for you, written in C#!  Two of 'em, in fact.  One solution
targets the old tried-and-true .NET Framework version 4.7, and the other targets .NET
5, which is the current version of .NET Core as of this writing.

Mind you, the .NET Framework version will give you a .EXE executable that runs
on its own, while you'll have to copy lots more files to get the .NET 5 version
to work.  Sorry, no installer - I'll leave that up to you.

But hey - no license, no muss, no fuss - it's just dead simple code.  Enjoy!

