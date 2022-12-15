namespace TheLongDarkNuGetFactory;

internal static class NuSpec
{
	public const string Path = $"{PackageInformation.Name}.nuspec";
	public const string Content = $"""
		<?xml version="1.0" encoding="utf-8"?>
		<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
		  <metadata>
		    <id>{PackageInformation.Name}</id>
		    <version>{PackageInformation.Version}</version>
		    <title>{PackageInformation.Name}</title>
		    <authors>{PackageInformation.Authors}</authors>
		    <license type="expression">{License.Type}</license>
		    <licenseUrl>{License.Url}</licenseUrl>
		    <readme>{ReadMe.Path}</readme>
		    <projectUrl>{PackageInformation.RepositoryLink}</projectUrl>
		    <description>{PackageInformation.Description}</description>
		    <copyright>Copyright © Hinterland Games</copyright>
		    <tags>{PackageInformation.Tags}</tags>
		    <repository type="git" url="{PackageInformation.RepositoryLink}" />
		    <dependencies>
		      <group targetFramework="net6.0">
		        <dependency id="AsmResolver.PE" version="5.0.0" exclude="Build,Analyzers" />
		        <dependency id="System.Text.Json" version="6.0.7" exclude="Build,Analyzers" />
		      </group>
		    </dependencies>
		  </metadata>
		</package>
		""";
	//To do: MelonLoader package dependency
}
