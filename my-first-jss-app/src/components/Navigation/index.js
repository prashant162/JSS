import React from 'react';
import { Link } from '@sitecore-jss/sitecore-jss-react';

const Navigation = (props) => (
    <div>
        <br/>
        <h1>Navigation Component</h1>
        <ul>
            {props.fields.childPages.map((childPage, index) => {
                return <li key={index}><Link field={childPage} /></li>
            })}
        </ul>
    </div>
);

export default Navigation;
