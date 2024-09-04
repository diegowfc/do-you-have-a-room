import React, { useState } from 'react';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import '../styles/RegisterUser.css'; // Import the CSS file

function RegisterUser() {
    const [formData, setFormData] = useState({
        name: '',
        email: '',
        password: '',
        dateOfBirth: '',
        phone: '',
        address: '',
        document: '',
        gender: ''
    });

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        // Simulate a successful registration
        toast.success('User registered successfully', {
            position: toast.POSITION.TOP_RIGHT,
            autoClose: 4000
        });
    };

    return (
        <form onSubmit={handleSubmit}>
            <div>
                <label>Name:</label>
                <input
                    type="text"
                    name="name"
                    value={formData.name}
                    onChange={handleChange}
                    maxLength="100"
                    required
                />
            </div>
            <div>
                <label>Email:</label>
                <input
                    type="email"
                    name="email"
                    value={formData.email}
                    onChange={handleChange}
                    maxLength="255"
                    required
                />
            </div>
            <div>
                <label>Password:</label>
                <input
                    type="password"
                    name="password"
                    value={formData.password}
                    onChange={handleChange}
                    maxLength="255"
                    required
                />
            </div>
            <div>
                <label>Date of Birth:</label>
                <input
                    type="date"
                    name="dateOfBirth"
                    value={formData.dateOfBirth}
                    onChange={handleChange}
                    required
                />
            </div>
            <div>
                <label>Phone:</label>
                <input
                    type="text"
                    name="phone"
                    value={formData.phone}
                    onChange={handleChange}
                    maxLength="15"
                />
            </div>
            <div>
                <label>Address:</label>
                <input
                    type="text"
                    name="address"
                    value={formData.address}
                    onChange={handleChange}
                    maxLength="255"
                />
            </div>
            <div>
                <label>Document:</label>
                <input
                    type="text"
                    name="document"
                    value={formData.document}
                    onChange={handleChange}
                    maxLength="255"
                />
            </div>
            <div>
                <label>Gender:</label>
                <input
                    type="text"
                    name="gender"
                    value={formData.gender}
                    onChange={handleChange}
                    maxLength="10"
                />
            </div>
            <button type="submit">Register</button>
            <ToastContainer />
        </form>
    );
}

export default RegisterUser;
