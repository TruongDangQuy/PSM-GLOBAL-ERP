Imports FarPoint.Win
Imports FarPoint.Win.SuperEditBase
Imports FarPoint.Win.ElementControl
Public MustInherit Class SuperEditBase
    Inherits ElementControl
    Implements IDropDownNotify, IElement, IPopUpNotify, ISlideLeftNotify, ISlideRightNotify, ISpinDownNotify, ISpinUpNotify

    Public Sub DropDownNotify(o As Object) Implements IDropDownNotify.DropDownNotify

    End Sub

    Public Sub PopUpNotify(o As Object) Implements IPopUpNotify.PopUpNotify

    End Sub

    Public Sub SlideLeftNotify(o As Object) Implements ISlideLeftNotify.SlideLeftNotify

    End Sub

    Public Sub SlideRightNotify(o As Object) Implements ISlideRightNotify.SlideRightNotify

    End Sub

    Public Sub SpinDownNotify(o As Object) Implements ISpinDownNotify.SpinDownNotify

    End Sub

    Public Sub SpinUpNotify(o As Object) Implements ISpinUpNotify.SpinUpNotify

    End Sub
End Class
