# Unity-Typewriter-Effect
This is a text typewriter effect made for Unity text objects. When game is run, text will appear letter by letter as though it is being typed in live.

How to Use:
1. Download "Typewriter Effect" C# script from this repository and place script in whatever Unity project you would like to use it in.
2. In Unity, add script as component to a new, unedited text object.
![1](https://user-images.githubusercontent.com/89488647/151676923-15e4ef97-ca52-4d8f-87c4-4ba5a73a93af.jpg)
3. <b>Text</b> - Under the typewriter component, there will be an array named "Words" with one item in it, containing the words "Hello World" in its text box. From now on, whenever you want to change the text displayed in the scene text box, simply change the text in the typewriter component. <b>(Note: Do NOT edit the text via the default text component)</b>
![2](https://user-images.githubusercontent.com/89488647/151678278-6be8d90a-0c44-48d2-bc83-8d761a403158.jpg)
4. <b>Delay</b> - Under the text box, there is a variable called "Delay" where you can set the pause time (in seconds) in between each letter being typed.
![3](https://user-images.githubusercontent.com/89488647/151678322-67a758bd-69d6-4066-8df2-04b1287e5444.jpg)
5. <b>Multiple Text Sections</b> - If you want different parts of the text to show up at different speeds, you can add more sections by clicking the "+" button at the bottom of the "Words" array.
![4](https://user-images.githubusercontent.com/89488647/151678498-dcf04c2a-218f-48b3-bf2d-035b7517f003.jpg)
Now, you can change the other sections' delay, color, and text as you wish.
![5](https://user-images.githubusercontent.com/89488647/151678624-db659804-a0e7-4d0d-807e-5b0103bf7875.jpg)
6. <b>Pauses</b> - If you would like to pause for a certain amount of time in between text sections, simply add a new section and change its text to "Pause". Now, the words will pause typing when it reaches the location of your pause. You can adjust the pause time using the "Pause Time" variable at the top of the component.
![6](https://user-images.githubusercontent.com/89488647/151679383-e89e5ad2-43f4-470e-99d8-86484bffc109.jpg)
