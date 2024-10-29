## Cascading Nature of css

1. **Inline styles** (the highest priority)
2. **ID**
3. **Classes, attributes**
4. **Elements(tags)**


## Variables

```css
/*GlobalStyle.css*/
:root{
    --primary-color: #000000;
    --secondary-color: blue;
}

/*MyHTMLPageStyle.css*/

h1{
    font-color: var(--primary-color);
}


```