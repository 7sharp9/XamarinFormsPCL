namespace XamarinFormsTest

open Xamarin.Forms

    type App =

        static member GetMainPage () =
 
            let cp = ContentPage() 
            cp.Content <- Label(Text = "Hello, Forms!",
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.CenterAndExpand)
            cp :> Page
