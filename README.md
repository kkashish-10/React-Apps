# React-Apps

[Learning React Js](https://roadmap.sh/react)

## CLI Tools

`Here is the list of most common CLI tools for React development:`

- [x] [create-react-app](https://create-react-app.dev/)
- [ ] [vite](https://vitejs.dev/)

  ### Create-react-app

  - https://create-react-app.dev/docs/getting-started/

## Components

`Components are the building blocks of React applications. They let us split the UI into independent, reusable pieces, and think about each piece in isolation.`

- [x] [Components and Props](https://reactjs.org/docs/components-and-props.html)
- [x] [Components in depth]()

  ## Components and Props

  - https://reactjs.org/docs/components-and-props.html
  - Components let you split the UI into independent, reusable pieces, and think about each piece in isolation.Conceptually, components are like JavaScript functions. They accept arbitrary inputs (called “props”) and return React elements describing what should appear on the screen.

    ### Functional and Class Components

  - The simplest way to define a component is to write a JavaScript function.
  - This function is a valid React component because it accepts a single “props” (which stands for properties) object argument with data and returns a React element. We call such components “function components” because they are literally JavaScript functions.

        ```
        function Welcome(props) {
            return <h1>Hello, {props.name}</h1>;
        }
        ```

    ### ES6 class

        ```
        class Welcome extends React.Component {
            render() {
                return <h1>Hello, {this.props.name}</h1>;
            }
        }
        ```
