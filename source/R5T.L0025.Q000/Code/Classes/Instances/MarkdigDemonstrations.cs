using System;


namespace R5T.L0025.Q000
{
	public class MarkdigDemonstrations : IMarkdigDemonstrations
	{
		#region Infrastructure

	    public static MarkdigDemonstrations Instance { get; } = new();

	    private MarkdigDemonstrations()
	    {
        }

	    #endregion
	}
}