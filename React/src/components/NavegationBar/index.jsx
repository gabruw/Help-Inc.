//#region Imports
import React, { Fragment } from 'react';
import { Menu, Segment, Grid } from 'semantic-ui-react';
import MainButton from './../../components/Button/index';
import styles from './styles.module.css';
import './styles.css';
import NavegationBar from './index';

//#endregion
const navegationBar = () => (
    <Fragment>
        <Segment inverted>
            <Grid>
                <Menu className={styles.navegationmenu} inverted>
                    <Menu.Item>
                        {' '}
                        <MainButton text='Registrar' />{' '}
                    </Menu.Item>
                    <Menu.Item>
                        {' '}
                        <MainButton className={styles.mainButton} text='Entrar' />{' '}
                    </Menu.Item>
                </Menu>
            </Grid>
        </Segment>
        <div style={{ height: '20000px' }}> </div>
    </Fragment>
);

export default navegationBar;
