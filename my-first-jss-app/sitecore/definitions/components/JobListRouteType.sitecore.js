// eslint-disable-next-line no-unused-vars
import { CommonFieldTypes, SitecoreIcon, Manifest } from '@sitecore-jss/sitecore-jss-manifest';

/**
 * Adds the Styleguide-CustomRouteType component to the disconnected manifest.
 * This function is invoked by convention (*.sitecore.js) when 'jss manifest' is run.
 * @param {Manifest} manifest Manifest instance to add components to
 */
export default function(manifest) {
  // This registers the custom route type with the manifest.
  // Like a component, a route type contains data fields -
  // but unlike a component, the fields are shared at the route level,
  // instead of at the component level. This is good for scenarios such as
  // article sections, where you may wish to use route-level fields for
  // _sorting and filtering_ (it's difficult to query on component-level field data).
  manifest.addRouteType({
      name: 'JobDetail',
      displayName: 'Job Detail',
    fields: [
      { name: 'Job Title', type: CommonFieldTypes.SingleLineText },
      { name: 'Job Summary', type: CommonFieldTypes.SingleLineText },
      { name: 'Job Desription', type: CommonFieldTypes.RichText },
    ],
  });
}
