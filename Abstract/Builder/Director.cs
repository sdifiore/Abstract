namespace Abstract.Builder
{
	internal class Director
	{
		public void Build(IDatabaseBuilder builder)
		{
			builder.BuildConnection();
			builder.BuildCommand();
			builder.SetSetting();
		}
	}
}
