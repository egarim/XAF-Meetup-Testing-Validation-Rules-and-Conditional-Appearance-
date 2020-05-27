;#DropDB FirstXafProjectEasyTest

#Application FirstXafProjectWin
#Application FirstXafProjectWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef FirstXafProjectWin

*Action About...
 
*Action OK

#EndIf

#IfDef FirstXafProjectWeb
*Action Navigation(My Details)
#EndIf
