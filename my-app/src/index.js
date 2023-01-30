import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import HookA from './components/HookA';
import HookB from './components/HookB';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App />
    <HookA />
    <HookB />
  </React.StrictMode>
);

console.log(HookA);
// root.render(Parantheses());

