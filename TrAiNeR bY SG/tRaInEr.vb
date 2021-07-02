' NativeUI IV VB.NET example script for version 0.7.

Option Strict On
Imports System.Drawing
Imports System.Windows.Forms
Imports GTA
Imports NativeUI

Public Class Trainer : Inherits Script

#Region "Other"
    Private testGif As Image
#End Region

#Region "Native UI"
    Private mainmenu As UIMenu 'main menu - SG's Trainer
    Private uiMenu1 As UIMenu 'teleportation
    Private uiMenu2 As UIMenu 'spawning
    Private uiMenu3 As UIMenu 'player related
    Private uiMenu4 As UIMenu 'main option like godmode
    Private uiMenu5 As UIMenu 'dispatching
    Private uiMenu6 As UIMenu 'scoloader
    Private uiMenu7 As UIMenu 'missionloader
    Private uiMenu8 As UIMenu 'task for player
    Private uiMenu9 As UIMenu 'weapon
    Private uiMenu10 As UIMenu 'weather

    Private uiMenu1 As UIMenu 'car spawning
    Private uiMenu2 As UIMenu 'ped Spawning
    Private uiMenu3 As UIMenu 'gang Spawning
    Private uiMenu4 As UIMenu 'police Spawning
    Private uiMenu5 As UIMenu 'ig peds
    Private uiMenu6 As UIMenu 'helicopters
    Private uiMenu7 As UIMenu 'boats
    Private uiMenu8 As UIMenu 'emergency 
    Private uiMenu9 As UIMenu 'bikes
    Private uiMenu10 As UIMenu 'planes

    Private uiMenu1 As UIMenu 'aod
    Private uiMenu2 As UIMenu 'lost
    Private uiMenu3 As UIMenu 'albanian
    Private uiMenu4 As UIMenu 'korean
    Private uiMenu5 As UIMenu 'japsnese
    Private uiMenu6 As UIMenu 'af-american
    Private uiMenu7 As UIMenu 'jamacuan
    Private uiMenu8 As UIMenu 'italian
    Private uiMenu9 As UIMenu 'russian
    Private uiMenu10 As UIMenu 'russian2

    Private uiMenu1 As UIMenu '2door
    Private uiMenu2 As UIMenu 'sport
    Private uiMenu3 As UIMenu 'sedan
    Private uiMenu4 As UIMenu '4door
    Private uiMenu5 As UIMenu 'police
    Private uiMenu6 As UIMenu 'truck
    Private uiMenu7 As UIMenu 'pickup 
    Private uiMenu8 As UIMenu 'suv
    Private uiMenu9 As UIMenu 'pickup truck
    Private uiMenu10 As UIMenu '2-wheel

    Private uiMenu1 As UIMenu 'heavy
    Private uiMenu2 As UIMenu 'assault
    Private uiMenu3 As UIMenu 'smg
    Private uiMenu4 As UIMenu 'shotty
    Private uiMenu5 As UIMenu 'pistol
    Private uiMenu6 As UIMenu 'melee
    Private uiMenu7 As UIMenu 'throwables
    Private uiMenu8 As UIMenu 'vehicle mounted-minigun,cannon, missile pod
    Private uiMenu9 As UIMenu 'ammo
    Private uiMenu10 As UIMenu 'gunvan


    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem
    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem

    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem
    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem

    ' Items
    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem
    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem
    Private uiMenuItem1 As UI.UIMenuItem
    Private uiMenuItem2 As UI.UIMenuItem
    Private uiMenuItem3 As UI.UIMenuItem
    Private uiMenuItem4 As UI.UIMenuItem
    Private uiMenuItem5 As UI.UIMenuItem


    Private uIMenuCheckBoxItem1 As UI.UIMenuCheckboxItem
    Private uIMenuCheckBoxItem2 As UI.UIMenuCheckboxItem
    Private uIMenuCheckBoxItem3 As UI.UIMenuCheckboxItem
    Private uIMenuCheckBoxItem4 As UI.UIMenuCheckboxItem

    Private uiListItem1 As UI.UIMenuListItem
#End Region

    Public Sub New()
        ' Load test gif - Replace path with your gif file.
        testGif = Image.FromFile(Game.InstallFolder + "\\scripts\\NativeUITest\\testGif.gif")

        ' Set settings for all menus
        UIMenu.Options.UpKey = Keys.Up
        UIMenu.Options.DownKey = Keys.Down
        UIMenu.Options.LeftKey = Keys.Left
        UIMenu.Options.RightKey = Keys.Right
        UIMenu.Options.AcceptKey = Keys.Enter
        UIMenu.Options.disablePhoneWhenMenuIsOpened = True
        UIMenu.Options.enableControllerSupport = True
        UIMenu.Options.enableMenuSounds = True
        UIMenu.Options.AnimatedBannerFrameRate = 120

#Region "Menu1"
        ' Create a New menu
        mainmenu = New UIMenu("NativeUI IV", "NATIVEUI IV SHOWCASE", testGif)
        uiMenu1 = New UIMenu("Teleportation", "Teleportation Settings.")
        uiMenu2 = New UIMenu("Spawning", "Pedestrian, Vehicle and Object Spawning Settings.")
        uiMenu3 = New UIMenu("Player", "Player settings like spawning ped as Player or giving health.")
        uiMenu4 = New UIMenu("Miscellaneous Settings", "God Mode, Special Mode, Airbreak, Loose control over Player.")
        uiMenu5 = New UIMenu("Emergency Dispatching", "Dispatch Police, Ambulance and Fire Fighters to help you.")
        uiMenu6 = New UIMenu("SCO Loader/Unloader", "Load/Unload SCO Scripts.")
        uiMenu7 = New UIMenu("Weapons", "Weapons, Ammo, Attachments, and GunVan.")
        uiMenu8 = New UIMenu("Weather", "Weather Type, Timescale, Time.")
        uiMenu9 = New UIMenu("BodyGuards", "Bodyguards.")



        ' Create default items
        ' for main menu
        'teleportation
        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Teleport to Waypoint", "Teleport player to waypoint. Select this option after selecting your waypoint.", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Luis's House", "Teleport to Luis Fernando Lopez house.", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Johnny's Alderney House", "Teleport to Johnny Klebitz house.", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "The Lost MC Clubhouse", "Teleport to Clubhouse.", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Niko's Bohan Apartment", "Teleport to Bohan Apartment.", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Niko's Broker Apartment", "Teleport to Broker Apartment.", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Niko's Alderney Apartment", "Teleport to Alderney Apartment.", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Niko's Middle Park Safehouse", "Teleport to Middle Park Safehouse.", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Playboy X Luxury House", "Teleport to Playboy X Luxury House.", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Airport", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Alderney", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Algonquin", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Broker", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Bohan", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "LCPD Headquarter", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "NOoSE/FIB Headquarter", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Happiness Island", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Subway Station (Nearest)", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Subway Station (Random)", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)


        'spawning 
        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Pedestrian Spawning", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Vehicle Spawning", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Object Spawning", "You can't click on me... :(", False)

        'ped related can be used as bodyguard too
        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "In-game Peds", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Gang Peds", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Emergency Peds", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Background Peds", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Foreground Peds", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Cutscene Peds", "This is a default menu item just with an icon!", True)

        'vehicle
        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Emergency Vehicles", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Ground Vehicles", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Air Vehicles", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Aquatic Vehicles", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Two-wheelers", "You can click on me!", True)


        'ground
        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Sedans", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Sports", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Muscles", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Vans", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Trucks", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "SUVs", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Four-Doors", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Two-Doors", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Off-Roaders", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Buses", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Personal Carriers", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Armed Helicopters", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Armed Personal Carriers", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Speed-Boats", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "Choppers", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Luxuries", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Transporters", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Tug Boats", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        '

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "God Mode", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "Special God Mode", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "Add Health", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Add Armour", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)

        uiMenuItem1 = New UI.UIMenuItem("TestItem1", "I'm a button", "You can click on me!", True)

        uiMenuItem2 = New UI.UIMenuItem("TestItem2", "I'm a disabled button", "You can't click on me... :(", False)

        uiMenuItem3 = New UI.UIMenuItem("TestItem3", "Showcase button", "This is a long text. But wait, it can get even longer! It doesn't stop getting longer! Send help please! Quick! ...", True)

        uiMenuItem4 = New UI.UIMenuItem("TestItem4", "More information...", "This is a default menu item just with an icon!", True)



        ' Create default item with a nested menu.
        ' Menus
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2
        uiMenuItem5 = New UI.UIMenuItem("TestItem5", "Show another menu...", "This shows the nested menu set for this item.", True)
        uiMenuItem5.NestedMenu = uiMenu2




        ' Create list item
        ' uiListItem1 = New UI.UIMenuListItem("TestListItem1", "I'm a item with an list!", "Hit left, right to navigate through the list. Hit enter to show get the current selected item.", True)
        '    AddHandler uiListItem1.OnSelectedIndexChanged, AddressOf uiListItem1_OnSelectedIndexChanged
        '    AddHandler uiListItem1.OnClick, AddressOf uiListItem1_OnClick




        ' Add items to list
        '     uiListItem1.AddItem("-")
        '   uiListItem1.AddItem("Item1")
        '        uiListItem1.AddItem("Item2")
        '      uiListItem1.AddItem("And this is item 3")




        ' Add items to the main menu
        uiMenu1.AddItem(uiMenuItem1)
        uiMenu1.AddItem(uiMenuItem2)
        uiMenu1.AddItem(uiMenuItem3)
        uiMenu1.AddItem(uiMenuItem1)
        uiMenu1.AddItem(uiMenuItem4)
        uiMenu1.AddItem(uiMenuItem5)
#End Region

        ' Scripts stuff...
        Me.Interval = 100
        AddHandler Me.Tick, AddressOf Example_Tick
        AddHandler Me.PerFrameDrawing, AddressOf Example_PerFrameDrawing
        AddHandler Me.KeyDown, AddressOf Example_KeyDown
    End Sub

    Private Sub uiListItem1_OnSelectedIndexChanged(sender As UI.BaseElement, newIndex As Integer)
        Game.DisplayText("The new selected index is: " + newIndex.ToString())
    End Sub
    Private Sub uiListItem1_OnClick(sender As UI.BaseElement)
        Game.DisplayText("You clicked on item: " + sender.Name + " the selected item is: " + uiListItem1.SelectedText, 1500)
    End Sub

    Private Sub uIMenuCheckBoxItem1_OnCheckedChanged(sender As UI.BaseElement, newValue As Boolean)
        Game.DisplayText("CheckboxItem1 checked changed. New value = " + newValue.ToString(), 1500)
    End Sub

    Private Sub uiMenuItem2_Click(sender As UI.BaseElement)
        Game.DisplayText("'uiMenuItem2' is disabled so this should not show up ingame.", 1500)
    End Sub
    Private Sub uiMenuItem1_Click(sender As UI.BaseElement)
        Game.DisplayText("You clicked on button: " + sender.Name, 1500)
    End Sub


    Private Sub Example_Tick(sender As Object, e As EventArgs)
        UIMenu.ProcessController() ' Allows you to use a controller to navigate through the menu. (Make sure that 'enableControllerSupport' is enabled)
    End Sub
    Private Sub Example_PerFrameDrawing(sender As Object, e As GraphicsEventArgs)
        UIMenu.ProcessDrawing(e) ' Very important! This is used to draw the hole menu.
    End Sub
    Private Sub Example_KeyDown(sender As Object, e As GTA.KeyEventArgs)
        UIMenu.ProcessKeyPress(e) ' Also very important! This Is used To navigate through the menu With a keyboard.
        If e.Key = Keys.G Then ' If Key 'G' is pressed, open or close the menu.
            If UIMenu.IsAnyMenuOpen() Then ' Check Then If any Then Menu Is opened right now.
                UIMenu.HideAllMenus() ' If True Then hide all menus.
            Else
                UIMenu.Show(mainmenu) ' If False Then show main menu.
            End If
        End If
    End Sub

End Class
