// eslint-disable-next-line no-unused-vars
import { CommonFieldTypes, Manifest } from '@sitecore-jss/sitecore-jss-manifest';

/**
 * This is the data template for an Job list page
 * @param {Manifest} manifest Manifest instance to add components to
 */
export default function(manifest) {
  manifest.addTemplate({
    name: 'JobDetail',
    displayName: 'Job Detail',
    fields: [
      { name: 'Title', type: CommonFieldTypes.SingleLineText },
      { name: 'Summary', type: CommonFieldTypes.SingleLineText },
      { name: 'Detail', type: CommonFieldTypes.RichText},
    ],
  });
}
