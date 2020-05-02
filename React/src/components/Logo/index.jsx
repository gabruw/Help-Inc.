//#region Imports

import { debounce } from 'lodash';
import React, { Fragment, useState } from 'react';
import { Link, withRouter } from 'react-router-dom';

import Sample from './sample';
import { Grid, Transition } from 'semantic-ui-react';

import styles from './styles.module.scss';

//#endregion

const Logo = () => {
    const [rotate, setRotate] = useState(false);
    const delayedRotateState = debounce(() => setRotate(!rotate), 2000);

    const onHover = () => {
        delayedRotateState();
    };

    const duration = rotate ? '4000' : '3000';
    return (
        <Fragment>
            <Grid style={{ height: '100px' }}>
                <Grid.Row className={styles.logo} style={{ height: '90px', marginTop: '5px', marginLeft: '20px' }}>
                    <Grid.Column widescreen={2} tablet={5} mobile={11}>
                        <Link to='/home'>
                            <div onMouseOut={() => onHover()}>
                                <Sample canRotate={rotate} />
                            </div>
                        </Link>

                        <Transition.Group animation={'fade right'} duration={duration}>
                            {rotate && <span className={styles.name}>help inc.</span>}
                        </Transition.Group>
                    </Grid.Column>
                </Grid.Row>
            </Grid>
        </Fragment>
    );
};

export default withRouter(Logo);
