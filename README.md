# SimpleAutoClicker
Why do we need to buy an autoclicker application while we can build one. This is a very simple autoclicker app runs on Windows. We will fix bug and update more features.

- Go to here to run the AutoClick.exe: SimpleAutoClicker\bin\Debug\net5.0-windows.
- Go to here to open the code and fix and update (up to you): SimpleAutoClicker\AutoClick.sln

![image](https://user-images.githubusercontent.com/22828476/116747527-09eece80-a9cc-11eb-8df5-fbd7229248f3.png)


Second(s): how many second between each click.
**Total click(s):** how many click you want to.
**Start after - second(s):** how many seconds after you hit START button that you want this app to start working.
**Pause for - second(s) if mouse was moved:** while the app is running, if your mouse was moved, the app will be paused for the second(s) you set.
**Current clicks count:** what is the current click at the time you are looking at it.
A hidden start/stop time will pop up when you hit the START button.

Bugs: 
- Click won't pause while the mouse is moving - fixed but not 100% satisfying because we are using async, it will just pause after all tasks have finished.
- The form should be fixed size (not resizeable)

Feature:
- PAUSE button has not intergated yet.
- Calculate the total time or estimate time to perform the click from start to stop
- Click close form button (X button) should pop up a confirmation. To prevent accidentaly hitting close the form unintentionally.
