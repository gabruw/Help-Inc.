//#region Imports

import React, { Fragment, useState } from 'react';
import { Link, withRouter } from 'react-router-dom';

import { debounce } from 'lodash';
import { Grid, Transition } from 'semantic-ui-react';

import IMAGES from '../../library/images';
import styles from './styles.module.scss';

//#endregion

const Logo = () => {
    const [ap, setAp] = useState(false);
    const delayedApState = debounce(() => setAp(!ap), 2000);

    const onHover = () => {
        delayedApState();
    };

    const blueRect = ap ? styles.blueRectangleRotate : '';
    const grayRect = ap ? styles.grayRectangleRotate : styles.grayRectangleDefaultRotate;

    return (
        <Fragment>
            <Grid style={{ height: '100px' }}>
                <Grid.Row className={styles.logo} style={{ height: '90px', marginTop: '5px', marginLeft: '20px' }}>
                    <Grid.Column widescreen={2} tablet={5} mobile={11}>
                        <Link to='/home'>
                            <div onMouseOut={() => onHover()}>
                                <div className={[styles.blueRectangle, blueRect].join(' ')}></div>
                                <div className={[styles.grayRectangle, grayRect].join(' ')}></div>
                                <img className={styles.hammer} src={IMAGES.HAMMER} />
                            </div>
                        </Link>

                        <Transition.Group animation={'fade right'} duration={ap ? '4000' : '3000'}>
                            {ap && <span className={styles.name}>help inc.</span>}
                        </Transition.Group>
                    </Grid.Column>
                </Grid.Row>
            </Grid>
        </Fragment>
    );
};

export default withRouter(Logo);
