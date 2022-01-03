namespace MauiApp22;

public partial class MyCustomViewCell : ViewCell
{
    public MyCustomViewCell()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CodeProperty =
        BindableProperty.Create("Code", typeof(string), typeof(MyCustomViewCell), "");

    public string Code
    {
        get { return (string)GetValue(CodeProperty); }
        set { SetValue(CodeProperty, value); }
    }

    public static readonly BindableProperty NameProperty =
        BindableProperty.Create("Name", typeof(string), typeof(MyCustomViewCell), "");

    public string Name
    {
        get { return (string)GetValue(NameProperty); }
        set { SetValue(NameProperty, value); }
    }
}