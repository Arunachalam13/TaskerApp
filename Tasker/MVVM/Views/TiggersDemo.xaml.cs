namespace Tasker.MVVM.Views;

public partial class TiggersDemo : ContentPage
{
	public TiggersDemo()
	{
		InitializeComponent();
	}
}

public class FadeTriggerAction : TriggerAction<VisualElement>
{
    public int StartsFrom { get; set; }

    protected override void Invoke(VisualElement sender)
    {
        sender.Animate("FadeTriggerAction", new Animation((d) =>
        {
            var val = StartsFrom == 1 ? d : 244 - d;
            sender.BackgroundColor = Color.FromRgb(1, val, 1);
        }),
        length: 1000, // milliseconds
        easing: Easing.Linear);
    }
}