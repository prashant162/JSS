using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.JavaScriptServices.AppServices.Data;
using Sitecore.JavaScriptServices.AppServices.Datasources;
using Sitecore.JavaScriptServices.AppServices.Models;
using Sitecore.JavaScriptServices.AppServices.Pipelines.Import;
using Sitecore.JavaScriptServices.Configuration;

namespace SitecoreJss93.Extension
{
    public class ProcessRenderingOnImport : ProcessRenderings
    {
        public ProcessRenderingOnImport(IDatasourceStrategyFactory datasourceStrategyFactory) : base(datasourceStrategyFactory)
        {
        }

        protected override Item CreateRendering(RenderingDef renderingDef, ImportPipelineArgs args, IdManager idManager, AppConfiguration app, IDatasourceStrategy datasourceStrategy = null)
        {
            var renderingItem = base.CreateRendering(renderingDef, args, idManager, app, datasourceStrategy);

            if (renderingItem == null)
            {
                return null;
            }
            if (renderingDef.AdditionalData == null || !renderingDef.AdditionalData.ContainsKey("contentResolverItem"))
            {
                return renderingItem;
            }

            Log.Info("Rendering name is: " + renderingDef.Name, this);

            if (renderingDef.Name == "Navigation")
            {
                renderingItem.Editing.BeginEdit();
                renderingItem.Fields["{B0B15510-B138-470E-8F33-8DA2E228AAFE}"].Value = renderingDef.AdditionalData["contentResolverItem"].ToString();
                renderingItem.Editing.EndEdit();
            }
            
            return renderingItem;
        }
    }
}