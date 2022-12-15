using ICSharpCode.SharpZipLib.Zip;

namespace TheLongDarkNuGetFactory;

internal record class StreamDataSource(Stream Stream) : IStaticDataSource
{
	Stream IStaticDataSource.GetSource() => Stream;
}
