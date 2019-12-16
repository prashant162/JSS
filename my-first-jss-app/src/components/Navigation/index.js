import React from 'react';
import { Link } from '@sitecore-jss/sitecore-jss-react';

const Navigation = (props) => (
    <div>
        <p>Navigation Component</p>
        <Link field={props.fields.path} />
    </div>
);

export default Navigation;
