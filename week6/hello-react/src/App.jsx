import './App.css';
import Header from './Header';

function App() {

  const username = "Alice";

  return (
    /* This is jsx syntax, so it means we can mix html tags with js*/
    <div className="App">
      <Header />
      <h1>Hello {username}</h1>
    </div>
  );
}

export default App;
