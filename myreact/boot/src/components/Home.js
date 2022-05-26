import React from 'react'
import { Col, Container, Row } from 'react-bootstrap'

export function Home(props) {
    

    return (
        <>
            <Container>
            <Row>
                <Col className='xs m-4 p-4'>
                    <p className='display-6'>리액트와 python을 이용하여 웹프로그래밍으로 개와 고양이를 판별할수 있도록 하였습니다.
                    </p>
                <br/>
                <p className='display-3 m-3 p-3'>모바일화면에 최적화되어있습니다.</p>
                </Col>
            </Row>
            </Container>
        </>
    )
}