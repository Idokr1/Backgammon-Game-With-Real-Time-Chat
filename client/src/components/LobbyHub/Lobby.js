import "./Lobby.css";
import UsersContainer from "./UsersContainer/UsersContainer";
import GameLogic from "./GameContainer/GameLogic";
import ChatContainer from "./ChatContainer/ChatContainer";
import { useState } from "react";

const Lobby = ({
  move,
  turn,
  color,
  setDices,
  dices,
  board,
  chat,
  connection,
  currentUser,
  users,
}) => {
  const [flag, setFlag] = useState(true);

  async function userClicked(otherUser) {
    await connection.invoke("EndGame", chat, null);

    if (otherUser === "allChat")
      await connection.invoke("GetChat", "", otherUser);
    else
      await connection.invoke(
        "GetChat",
        currentUser.username,
        otherUser.username
      );
  }

  return (
    <div>
      {!board && (
        <button className="helpBtn" onClick={() => setFlag(!flag)}>
          Info
        </button>
      )}
      {flag ? (
        <div className="lobby">
          <UsersContainer
            userClicked={userClicked}
            users={users}
            currentUser={currentUser}
            connection={connection}
          />
          {chat ? (
            <div className="game">
              <GameLogic
                move={move}
                currentUser={currentUser}
                turn={turn}
                color={color}
                setDices={setDices}
                dices={dices}
                board={board}
                connection={connection}
                chat={chat}
              ></GameLogic>
              <ChatContainer
                board={board}
                connection={connection}
                currentUser={currentUser}
                chat={chat}
              ></ChatContainer>
            </div>
          ) : (
            <h4 className="lobby-wating">Select a user to start a chat</h4>
          )}
        </div>
      ) : (
        <div className="lobby space">
          <h3>The Backgammon Game</h3>
          <h5>
            Backgammon is a two-player game of contrary movement in which each
            player has fifteen pieces, known traditionally as 'men' (short for
            'tablemen') but increasingly known as 'checkers' in the US in recent
            decades. These pieces move along twenty-four 'points' according to
            the roll of two dice.
          </h5>
          <hr />
          <h3>Rules:</h3>
          <a
            className="rulesLink"
            href="https://www.bkgm.com/rules.html"
            target="_blank"
          >
            Click Here to read about all the rules of Backgammon
          </a>
          <hr />
          <div className="showUsers">
            <div className="circle on" />
            Online User
          </div>
          <div className="showUsers">
            <div className="circle off" />
            Offline User
          </div>
          <div className="showUsers">
            <div className="circle play" />
            User that wants to play against you.
          </div>
        </div>
      )}
    </div>
  );
};

export default Lobby;
