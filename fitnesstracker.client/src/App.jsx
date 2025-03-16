import { Routes, Route } from 'react-router-dom';
import Frontpage from './pages/Frontpage';

function App() {
    return (

        <div>
            <Routes>
                <Route path="/" element={<Frontpage />} />


            </Routes>
        </div>

    );
}

export default App;