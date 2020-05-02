//#region Imports

import React, { Fragment } from 'react';

import IMAGES from '../../library/images';
import styles from './styles.module.scss';

//#endregion

const Sample = ({ canRotate = false }) => {
    const blueRect = canRotate ? styles.blueRectangleRotate : '';
    const grayRect = canRotate ? styles.grayRectangleRotate : styles.grayRectangleDefaultRotate;

    return (
        <Fragment>
            <div className={[styles.blueRectangle, blueRect].join(' ')}></div>
            <div className={[styles.grayRectangle, grayRect].join(' ')}></div>
            <img className={styles.hammer} src={IMAGES.HAMMER} />
        </Fragment>
    );
};

export default Sample;
