using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using ReactiveUI;
using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using TuneLab.GUI;
using TuneLab.GUI.Components;
using TuneLab.Utils;
using Button = TuneLab.GUI.Components.Button;

namespace TuneLab.GUI;

internal partial class Dialog : Window
{
    public enum ButtonType
    {
        Primary,
        Normal
    }

    private Grid titleBar;
    private Label titleLabel;
    private TextBlock messageTextBlock;

    public Dialog()
    {
        InitializeComponent();
        Focusable = true;
        CanResize = false;
        WindowState = WindowState.Normal;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
        Topmost = true;

        this.DataContext = this;
        this.Background = Style.BACK.ToBrush();
        Content.Background = Style.INTERFACE.ToBrush();

        titleBar = this.FindControl<Grid>("TitleBar") ?? throw new InvalidOperationException("TitleBar not found");
        titleLabel = this.FindControl<Label>("TitleLabel") ?? throw new InvalidOperationException("TitleLabel not found");
        messageTextBlock = this.FindControl<TextBlock>("MessageTextBlock") ?? throw new InvalidOperationException("MessageTextBlock not found");
    }

    public void SetTitle(string title)
    {
        titleLabel.Content = title;
        Title = title + " - TuneLab";
    }

    public void SetMessage(string message)
    {
        messageTextBlock.Text = message;
    }

    public Button AddButton(string text, ButtonType type)
    {
        ButtonsPanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
        var button = new Button() { MinWidth = 96, Height = 40 };

        if (type == ButtonType.Primary)
            button.AddContent(new() { Item = new BorderItem() { CornerRadius = 6 }, ColorSet = new() { Color = Style.BUTTON_PRIMARY, HoveredColor = Style.BUTTON_PRIMARY_HOVER } });

        if (type == ButtonType.Normal)
            button.AddContent(new() { Item = new BorderItem() { CornerRadius = 6 }, ColorSet = new() { Color = Style.BUTTON_NORMAL, HoveredColor = Style.BUTTON_NORMAL_HOVER } });

        button.AddContent(new() { Item = new TextItem() { Text = text }, ColorSet = new() { Color = type == ButtonType.Primary ? Colors.White : Style.LIGHT_WHITE } });

        button.Clicked += Close;
        var buttonStack = new StackPanel() { Orientation = Avalonia.Layout.Orientation.Horizontal, HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center, Children = { button }, Height = 40, Margin = new(0) };

        Grid.SetColumn(buttonStack, ButtonsPanel.ColumnDefinitions.Count - 1);
        ButtonsPanel.Children.Add(buttonStack);

        return button;
    }
}
