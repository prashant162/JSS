import React from 'react';
import { Text, withSitecoreContext } from '@sitecore-jss/sitecore-jss-react';

const MyTestJssComponent = (props) => (
  <div>
    <p>MyTestJssComponent Component</p>
    <Text field={props.fields.heading} />
  </div>
);

export default MyTestJssComponent;
