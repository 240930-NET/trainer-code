## Component Lifecycle in React

- Mounting - component inserted into DOM
```jsx

useEffect(() => {
    //You code what should happend here 
    // You can use fetch here to get initial data from db for example
}, [])// Empty dependency

```

- Updating - component props or state changes

```jsx

const [age, setAge] = useState (32);

useEffect(() => {
    //You code what should happend here 
   //If age updates please run the code here 
}, [age])// Empty dependency
```
- Unmounting - remove component from DOM

```jsx
useEffect(() => {
    //You code what should happend here 
 
    return () => {
        //clean up
        // can be a flag (true or false)
    }
}, [])// Empty dependency

```