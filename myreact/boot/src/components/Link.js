import React from 'react'
import { Col, Container, Row } from 'react-bootstrap'

export function Link(props) {
    return (
        <>
          <Container>
          <Row>
                <Col className='xs m-4 p-4'>
                    <p className='display-6'>
                      리액트 화면이라서 싱글 페이지로 구현되어 있습니다.
                    </p>
                <br/>
                <p className='display-4 m-3 p-3'>아직 딥러닝공부의 기초단계이지만 추후 발전하는 모습을 보이도록 하겠습니니다.</p>
                <p className='display-2 m-3 p-3'>감사합니다</p>
                </Col>
            </Row>
            </Container>
        </>
    )
}
