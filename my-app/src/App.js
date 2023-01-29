import React from 'react'

const Greeting = ({ text }) => {
  return <p>{text}</p>
}

export function Parantheses() {
  return (<h1> As usual we can call the function using name of the function followed by
    Parentheses </h1>);
}

const App = () => {
  return (
    <div><p>Hello React</p>
      <Greeting text="Hello Instance 1 of Greeting" />
      <Greeting text="Hello Instance 2 of Greeting" />
      <Parantheses />
    </div>
  )
}

export default App;