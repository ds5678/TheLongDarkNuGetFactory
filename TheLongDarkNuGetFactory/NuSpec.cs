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
		        <dependency id="AsmResolver.DotNet" version="6.0.0-beta.3" exclude="Build,Analyzers" />
		        <dependency id="AssetRipper.Primitives" version="3.1.4" exclude="Build,Analyzers" />
		        <dependency id="AssetsTools.NET" version="3.0.0-preview3" exclude="Build,Analyzers" />
		        <dependency id="HarmonyX" version="2.10.2" exclude="Build,Analyzers" />
		        <dependency id="Il2CppInterop.Runtime" version="1.5.1" exclude="Build,Analyzers" />
		        <dependency id="LavaGang.MelonLoader" version="0.7.1" exclude="Build,Analyzers" />
		      </group>
		    </dependencies>
		  </metadata>
		</package>
		""";
	// MelonLoader doesn't have package references in its NuGet package, so we copy them from the .csproj file.
	// https://github.com/LavaGang/MelonLoader/blob/v0.7.1/MelonLoader/MelonLoader.csproj
}
