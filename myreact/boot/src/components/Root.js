import React, { useRef, useState } from 'react';
import { Form,Button, Container, Row, Col } from 'react-bootstrap';
import axios from 'axios';

export function Root(props) {
    const fileinput = useRef()
    const [myfile,setMyfile] = useState('');
    const [result,setResult] = useState('');

    const url ="http://localhost:5001/fileupload"

    const handleFileInput = (e)=>{
        setMyfile(e.target.files[0])
    }

    const uploadFile = (e) => {
        const formData = new FormData();
        formData.append('file', myfile);

        return axios.post(url, formData).then(res => {
            console.log(res.data)
            // alert('성공')
            setResult(res.data)
            setMyfile('')
        }).catch(err => {
            // alert('실패')
        })
        
      }
    return (
        <>
            <Container>
                <Row>
                    <Col className='xs'>
                        <Form>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>input file = </Form.Label>
                            <Form.Control type="file" ref={fileinput} onChange={e => handleFileInput(e)}/>
                        </Form.Group>
                        <Button type="button" onClick={uploadFile}>확인</Button>
                        </Form>
                    </Col>
                </Row>
                <Row>
                    <Col className='xs display-1 p-3 text-light bg-dark m-3'>&nbsp;{result}</Col>
                </Row>
            </Container>
        </>
    )
}
