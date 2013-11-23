using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.UI.Resources;

namespace Lombiq.AceEditor
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("AceEditor.NoConflict").SetUrl("ace/src-min-noconflict/ace.js", "ace/src-noconflict/ace.js").SetCdn("//d1n0x3qji82z53.cloudfront.net/src-min-noconflict/ace.js");
            manifest.DefineScript("AceEditor").SetUrl("ace/src-min/ace.js", "ace/src/ace.js");
        }
    }
}