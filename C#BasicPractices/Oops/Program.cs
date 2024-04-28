using Oops;

NonStaticClassCheck nonStaticClassCheck = new NonStaticClassCheck();
nonStaticClassCheck.NonStaticMethodOne();

/*//Calling sealed class
SealedClass sealedClass = new SealedClass();
sealedClass.InheritSealedClassMethod();*/

/*//Delegate
DelegateDemo obj = new DelegateDemo();
AddDel ad = new AddDel(obj.Add);
SayDel sd = new SayDel(obj.SayHello);
ad(100, 50); ad(200, 300);
//Console.WriteLine(sd("Hello"));*/


/*//Single dimension error
SDArrayDemo sDArrayDemo = new SDArrayDemo();
sDArrayDemo.SDArrayDemoMethod();*/

/*
//Switch case: 
SwitchCaseDemo switchCaseDemo = new SwitchCaseDemo();
switchCaseDemo.SwitchCaseDemoMethod();
*/

/*//If else condition 
IfDemo ifDemo = new IfDemo();
ifDemo.IfDemoMethod();*/

/*//var is the implicity type variable introduced in c# 8.0
TypesDemo implicityType =  new TypesDemo();
implicityType.TypesDemoMehtod();*/