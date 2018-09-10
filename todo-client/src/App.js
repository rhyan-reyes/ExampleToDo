import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import {todo_getAll} from './server';

class App extends Component {
  render() {
    state = {
      todos: []
    }

    // async componentDidMount() {
    //   const todos = await todo_getAll();

    //   this.setState({todos});
    // }

    componentDidMount() {
      todo_getAll.then(resp => {resp.data});
    }

    return (
      <div className="App">
        {/* <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          To get started, edit <code>src/App.js</code> and save to reload.
        </p> */}


      </div>
    );
  }
}

export default App;
