@import url("https://fonts.google.com/share?selection.family=Crimson+Text:ital,wght@0,400;0,600;0,700;1,400;1,600;1,700");

:root {
    --bg-color: #B8001F;
    --primary-color: #507687;
    --secondary-color: #697565;
    --font: "Nunito Sans", sans-serif;
}

body {
    background-color: var(--bg-color);
    color: var(--primary-color);
    font-family: var(--font);
    height: 100vh;
    margin: 0;
}

header {
    background-color: var(--primary-color);
    text-align: center;
    padding: 1px;
}

h1 {
    font-size: 2rem;
    color: var(--bg-color);
    font-weight: 700;
}

nav {
    display: flex;
    justify-content: center;
    font-weight: 400;
}

nav a {
    text-decoration: none;
    color: var(--bg-color);
    margin: 0 2rem 1rem 0rem;
    font-size: 1.2rem;
}

nav a:hover {
    text-decoration: underline;
    transform: scale(0.90);
    transition: transform 0.1s;
}

footer {
    display: flex;
    align-items: center;
    justify-content: center;
    background-color: var(--primary-color);
    color: var(--bg-color);
    width: 100%;
    height: 3rem;
    margin-top: 2rem;
}
