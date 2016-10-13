using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"neuroph_xamarin_plugin",
	Namespace = "neuroph_xamarin_plugin",
	Version = "0.1"
)]

[assembly: AddinName("Neuroph-For-Xamarin")]
[assembly: AddinCategory("Language Bindings")]
[assembly: AddinDescription("Xamarin Studio plugin which allows for easy integration of the Neuroph c# bindings into Xamarin Studio and easy to use examples")]
[assembly: AddinAuthor("Thomas Needham")]
