namespace Abstract.Builder
{
	internal interface IDatabaseBuilder
	{
		void BuildCommand();
		void BuildConnection();
		void SetSetting();
		Database Database { get; }
	}
}
