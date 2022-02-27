import axios from "axios";
import SendUserMessageModel from "../models/messages/sendUserMessageModel";
import SendMessageModel from "../models/messages/sendMessageModel";

import AuthHeader from "./auths/authHeader";
const BASE_URL = "https://localhost:44326/api/Messages/"
export default class MessageService{
    getMessages(){
        return axios.get(BASE_URL+"GetByUser",{headers:AuthHeader()})
    }

    sendMessage(receiverId,title,content){
        let message = new SendMessageModel(receiverId,title,content)
        return axios.post(BASE_URL,message,{headers:AuthHeader()})
    }

    sendMessageUser(title,content){
        let message = new SendUserMessageModel(title,content)
        return axios.post(BASE_URL,message,{headers:AuthHeader()})
    }
}