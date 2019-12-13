// eslint-disable-next-line no-unused-vars
import { CommonFieldTypes, Manifest } from '@sitecore-jss/sitecore-jss-manifest';

/**
 * This is the data template for an Job list page
 * @param {Manifest} manifest Manifest instance to add components to
 */
export default function(manifest) {
  manifest.addTemplate({
    name: 'JobList',
    displayName: 'Job List',
    fields: [
      { name: 'MainText', type: CommonFieldTypes.SingleLineText },
      { name: 'Description', type: CommonFieldTypes.RichText }
    ],
  });
}
