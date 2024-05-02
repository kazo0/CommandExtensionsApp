namespace CommandExtensionsApp;

public partial record MainModel
{
	public string[] Items { get; set; } = ["One", "Two", "Three"];
	public IState<string> CommandParameter => State.Value(this, () => string.Empty);
	public async Task DoSomething(object parameter)
	{
		await CommandParameter.UpdateAsync(_ => parameter.ToString());
		await Task.Delay(3000);
		await CommandParameter.UpdateAsync(_ => string.Empty);
	}
}
