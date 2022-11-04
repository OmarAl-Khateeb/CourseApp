import { Photo } from "./photo";

export interface Member {
    id: number;
    username: string;
    photoUrl: string;
    age: number;
    knownAs: string;
    createDate: Date;
    lastActive: Date;
    gender: string;
    lookingFor: string;
    introduction: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
}