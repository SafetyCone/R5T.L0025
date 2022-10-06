using System;

using Markdig;

using R5T.T0141;


namespace R5T.L0025.Q000
{
	[DemonstrationsMarker]
	public partial interface IMarkdigDemonstrations : IDemonstrationsMarker
	{
		public void HeadingsWithIDs()
        {
			var markdown = "# This is a heading";

			var markdownPipeline = new MarkdownPipelineBuilder()
				.UseAutoIdentifiers()
				.Build();

			var html =
				// <p>This is text with some <em>emphasis</em>.</p>
				Markdown.ToHtml(markdown, markdownPipeline);

			Console.WriteLine($"Markdown:\n{markdown}\n\nHTML:\n{html}");
		}

		public void FirstToHtml()
        {
			var markdown = "This is text with some *emphasis*.";

			var html =
				// <p>This is text with some <em>emphasis</em>.</p>
				Markdown.ToHtml(markdown);

			Console.WriteLine($"Markdown:\n{markdown}\n\nHTML:\n{html}");
        }
	}
}